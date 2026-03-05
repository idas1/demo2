<template>
  <div class="container py-4">
    <h2 class="section-title">⚙️ Quản trị Admin</h2>

    <!-- Tabs -->
    <ul class="nav nav-tabs-custom mb-4">
      <li class="nav-item">
        <button :class="['nav-link', activeTab === 'products' && 'active']" @click="activeTab = 'products'">📦 Sản phẩm</button>
      </li>
      <li class="nav-item">
        <button :class="['nav-link', activeTab === 'categories' && 'active']" @click="activeTab = 'categories'">📂 Danh mục</button>
      </li>
    </ul>

    <!-- ========== PRODUCTS TAB ========== -->
    <div v-if="activeTab === 'products'">
      <!-- Product Form -->
      <div ref="productFormPanel" class="admin-panel mb-4">
        <h3>{{ editingProduct ? '✏️ Sửa sản phẩm' : '➕ Thêm sản phẩm' }}</h3>
        <form @submit.prevent="saveProduct">
          <div class="row g-3">
            <div class="col-md-6">
              <label class="form-label">Tên sản phẩm *</label>
              <input v-model="productForm.name" class="form-control" required placeholder="Nhập tên sản phẩm" />
            </div>
            <div class="col-md-3">
              <label class="form-label">Giá gốc *</label>
              <input :value="productForm.originalPrice" @input="e => productForm.originalPrice = parseNumber(e.target.value)" type="number" min="0" step="1" class="form-control" required />
            </div>
            <div class="col-md-3">
              <label class="form-label">Giá sale</label>
              <input :value="productForm.salePrice" @input="e => productForm.salePrice = parseNumber(e.target.value)" type="number" min="0" step="1" class="form-control" />
            </div>
            <div class="col-md-6">
              <label class="form-label">Hình ảnh</label>
              <input type="file" accept="image/*" class="form-control" @change="onFileChange" />
            </div>
            <div class="col-md-6">
              <label class="form-label">Danh mục</label>
              <select v-model="productForm.categoryIds" class="form-select" multiple style="min-height: 80px;">
                <option v-for="cat in categories" :key="cat.id" :value="cat.id">{{ cat.name }}</option>
              </select>
            </div>
            <div class="col-12">
              <label class="form-label">Mô tả</label>
              <textarea v-model="productForm.content" class="form-control" rows="3" placeholder="Nhập mô tả sản phẩm"></textarea>
            </div>
            <div class="col-12">
              <button type="submit" class="btn btn-primary me-2">{{ editingProduct ? 'Cập nhật' : 'Thêm mới' }}</button>
              <button v-if="editingProduct" type="button" class="btn btn-outline-light" @click="cancelEditProduct">Hủy</button>
            </div>
          </div>
        </form>
      </div>

      <!-- Products Table -->
      <div class="table-responsive">
        <table class="table table-dark-custom">
          <thead>
            <tr>
              <th>ID</th>
              <th>Hình</th>
              <th>Tên</th>
              <th>Giá gốc</th>
              <th>Giá sale</th>
              <th>Danh mục</th>
              <th>Thao tác</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="p in products" :key="p.id">
              <td>{{ p.id }}</td>
              <td>
                <img :src="p.imagePath || 'https://via.placeholder.com/50/1e293b/6366f1'" style="width: 50px; height: 50px; object-fit: cover; border-radius: 8px;" />
              </td>
              <td>{{ p.name }}</td>
              <td>{{ formatPrice(p.originalPrice) }}</td>
              <td>{{ p.salePrice ? formatPrice(p.salePrice) : '—' }}</td>
              <td>
                <span v-for="cat in p.categories" :key="cat.id" class="badge-cat">{{ cat.name }}</span>
              </td>
              <td>
                <button class="btn btn-sm btn-primary me-1" @click="editProduct(p)">Sửa</button>
                <button class="btn btn-sm btn-danger" @click="removeProduct(p.id)">Xóa</button>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>

    <!-- ========== CATEGORIES TAB ========== -->
    <div v-if="activeTab === 'categories'">
      <!-- Category Form -->
      <div class="admin-panel mb-4">
        <h3>{{ editingCategory ? '✏️ Sửa danh mục' : '➕ Thêm danh mục' }}</h3>
        <form @submit.prevent="saveCategory" class="d-flex gap-3 align-items-end">
          <div class="flex-grow-1">
            <label class="form-label">Tên danh mục *</label>
            <input v-model="categoryForm.name" class="form-control" required placeholder="Nhập tên danh mục" />
          </div>
          <button type="submit" class="btn btn-primary">{{ editingCategory ? 'Cập nhật' : 'Thêm mới' }}</button>
          <button v-if="editingCategory" type="button" class="btn btn-outline-light" @click="cancelEditCategory">Hủy</button>
        </form>
      </div>

      <!-- Categories Table -->
      <div class="table-responsive">
        <table class="table table-dark-custom">
          <thead>
            <tr>
              <th>ID</th>
              <th>Tên danh mục</th>
              <th>Thao tác</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="cat in categories" :key="cat.id">
              <td>{{ cat.id }}</td>
              <td>{{ cat.name }}</td>
              <td>
                <button class="btn btn-sm btn-primary me-1" @click="editCategory(cat)">Sửa</button>
                <button class="btn btn-sm btn-danger" @click="removeCategory(cat.id)">Xóa</button>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted, nextTick, defineEmits } from 'vue'
import {
  getProducts, createProduct, updateProduct, deleteProduct,
  getCategories, createCategory, updateCategory, deleteCategory
} from '../services/api'

const emit = defineEmits(['show-toast'])
const activeTab = ref('products')
const productFormPanel = ref(null)

// ── Products ──
const products = ref([])
const editingProduct = ref(null)
const productForm = ref({ name: '', originalPrice: 0, salePrice: null, content: '', categoryIds: [] })
const selectedFile = ref(null)

const formatPrice = (price) => {
  return new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(price)
}

const parseNumber = (value) => {
  const num = Number(value)
  return isNaN(num) ? 0 : num
}

const onFileChange = (e) => {
  selectedFile.value = e.target.files[0]
}

const loadProducts = async () => {
  const res = await getProducts()
  products.value = res.data
}

const saveProduct = async () => {
  try {
    if (productForm.value.originalPrice <= 0) {
      emit('show-toast', 'Giá phải lớn hơn 0', 'error')
      return
    }
    if (!productForm.value.name.trim()) {
      emit('show-toast', 'Tên sản phẩm không được trống', 'error')
      return
    }

    const formData = new FormData()
    formData.append('name', productForm.value.name)
    formData.append('originalPrice', productForm.value.originalPrice)
    if (productForm.value.salePrice) formData.append('salePrice', productForm.value.salePrice)
    if (productForm.value.content) formData.append('content', productForm.value.content)
    productForm.value.categoryIds.forEach(id => formData.append('categoryIds', id))
    if (selectedFile.value) formData.append('image', selectedFile.value)

    if (editingProduct.value) {
      await updateProduct(editingProduct.value, formData)
      emit('show-toast', 'Cập nhật sản phẩm thành công!')
    } else {
      await createProduct(formData)
      emit('show-toast', 'Thêm sản phẩm thành công!')
    }

    cancelEditProduct()
    await loadProducts()
  } catch (e) {
    emit('show-toast', 'Lỗi: ' + (e.response?.data?.message || e.message), 'error')
  }
}

const editProduct = (p) => {
  editingProduct.value = p.id
  productForm.value = {
    name: p.name,
    originalPrice: p.originalPrice,
    salePrice: p.salePrice,
    content: p.content,
    categoryIds: p.categories.map(c => c.id)
  }
  selectedFile.value = null
  nextTick(() => {
    productFormPanel.value?.scrollIntoView({ behavior: 'smooth', block: 'start' })
  })
}

const cancelEditProduct = () => {
  editingProduct.value = null
  productForm.value = { name: '', originalPrice: 0, salePrice: null, content: '', categoryIds: [] }
  selectedFile.value = null
}

const removeProduct = async (id) => {
  if (!confirm('Bạn có chắc muốn xóa sản phẩm này?')) return
  try {
    await deleteProduct(id)
    emit('show-toast', 'Đã xóa sản phẩm!')
    await loadProducts()
  } catch (e) {
    emit('show-toast', 'Lỗi khi xóa sản phẩm', 'error')
  }
}

// ── Categories ──
const categories = ref([])
const editingCategory = ref(null)
const categoryForm = ref({ name: '' })

const loadCategories = async () => {
  const res = await getCategories()
  categories.value = res.data
}

const saveCategory = async () => {
  try {
    if (!categoryForm.value.name.trim()) {
      emit('show-toast', 'Tên danh mục không được trống', 'error')
      return
    }

    if (editingCategory.value) {
      await updateCategory(editingCategory.value, { name: categoryForm.value.name })
      emit('show-toast', 'Cập nhật danh mục thành công!')
    } else {
      await createCategory({ name: categoryForm.value.name })
      emit('show-toast', 'Thêm danh mục thành công!')
    }

    cancelEditCategory()
    await loadCategories()
  } catch (e) {
    emit('show-toast', 'Lỗi: ' + (e.response?.data?.message || e.message), 'error')
  }
}

const editCategory = (cat) => {
  editingCategory.value = cat.id
  categoryForm.value = { name: cat.name }
}

const cancelEditCategory = () => {
  editingCategory.value = null
  categoryForm.value = { name: '' }
}

const removeCategory = async (id) => {
  if (!confirm('Bạn có chắc muốn xóa danh mục này?')) return
  try {
    await deleteCategory(id)
    emit('show-toast', 'Đã xóa danh mục!')
    await loadCategories()
  } catch (e) {
    emit('show-toast', 'Lỗi khi xóa danh mục', 'error')
  }
}

onMounted(async () => {
  await Promise.all([loadProducts(), loadCategories()])
})
</script>

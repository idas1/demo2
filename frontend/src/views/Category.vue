<template>
  <div class="container py-4">
    <!-- Loading -->
    <div v-if="loading" class="spinner-wrapper">
      <div class="spinner-custom"></div>
    </div>

    <div v-else>
      <h2 class="section-title">{{ categoryName }}</h2>

      <!-- Sort Bar -->
      <div class="sort-bar">
        <span class="text-muted">{{ products.length }} sản phẩm</span>
        <div>
          <button :class="['btn btn-sm me-2', sortBy === '' ? 'btn-primary' : 'btn-outline-light']" @click="changeSort('')">Mặc định</button>
          <button :class="['btn btn-sm me-2', sortBy === 'price_asc' ? 'btn-primary' : 'btn-outline-light']" @click="changeSort('price_asc')">Giá tăng ↑</button>
          <button :class="['btn btn-sm', sortBy === 'price_desc' ? 'btn-primary' : 'btn-outline-light']" @click="changeSort('price_desc')">Giá giảm ↓</button>
        </div>
      </div>

      <!-- Products Grid -->
      <div class="row g-4">
        <div v-for="product in products" :key="product.id" class="col-6 col-md-4 col-lg-3">
          <div class="product-card" @click="$router.push(`/product/${product.id}`)">
            <img :src="product.imagePath || 'https://via.placeholder.com/300x220/1e293b/6366f1?text=' + encodeURIComponent(product.name)" :alt="product.name" />
            <div class="card-body">
              <h5 class="card-title">{{ product.name }}</h5>
              <div v-if="product.salePrice">
                <span class="price-original">{{ formatPrice(product.originalPrice) }}</span>
                <span class="price-sale ms-2">{{ formatPrice(product.salePrice) }}</span>
              </div>
              <div v-else>
                <span class="price-normal">{{ formatPrice(product.originalPrice) }}</span>
              </div>
              <div class="mt-2">
                <span v-for="cat in product.categories" :key="cat.id" class="badge-cat">{{ cat.name }}</span>
              </div>
            </div>
          </div>
        </div>
      </div>

      <div v-if="products.length === 0" class="text-center py-5">
        <p class="text-muted fs-5">Không có sản phẩm nào trong danh mục này</p>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted, watch } from 'vue'
import { useRoute } from 'vue-router'
import { getProductsByCategory, getCategories } from '../services/api'

const route = useRoute()
const products = ref([])
const loading = ref(true)
const sortBy = ref('')
const categoryName = ref('')

const formatPrice = (price) => {
  return new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(price)
}

const fetchProducts = async () => {
  loading.value = true
  try {
    const categoryId = route.params.id
    const [prodRes, catRes] = await Promise.all([
      getProductsByCategory(categoryId, sortBy.value),
      getCategories()
    ])
    products.value = prodRes.data
    const cat = catRes.data.find(c => c.id === parseInt(categoryId))
    categoryName.value = cat ? cat.name : 'Danh mục'
  } catch (e) {
    console.error('Failed to load products', e)
  } finally {
    loading.value = false
  }
}

const changeSort = (sort) => {
  sortBy.value = sort
  fetchProducts()
}

onMounted(fetchProducts)
watch(() => route.params.id, fetchProducts)
</script>

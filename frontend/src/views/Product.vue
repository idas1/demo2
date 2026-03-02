<template>
  <div class="container py-4">
    <!-- Loading -->
    <div v-if="loading" class="spinner-wrapper">
      <div class="spinner-custom"></div>
    </div>

    <div v-else-if="product">
      <button class="btn btn-outline-light mb-3" @click="$router.back()">← Quay lại</button>

      <div class="row g-4">
        <!-- Image -->
        <div class="col-md-6">
          <img :src="product.imagePath || 'https://via.placeholder.com/600x500/1e293b/6366f1?text=' + encodeURIComponent(product.name)" :alt="product.name" class="product-detail-img" />
        </div>

        <!-- Info -->
        <div class="col-md-6">
          <div class="product-detail-info">
            <h1>{{ product.name }}</h1>

            <div class="mb-3">
              <span v-for="cat in product.categories" :key="cat.id" class="badge-cat">{{ cat.name }}</span>
            </div>

            <div class="mb-4">
              <div v-if="product.salePrice" class="d-flex align-items-center gap-3">
                <span class="price-original fs-5">{{ formatPrice(product.originalPrice) }}</span>
                <span class="price-sale fs-3">{{ formatPrice(product.salePrice) }}</span>
                <span class="badge bg-danger">-{{ discount }}%</span>
              </div>
              <div v-else>
                <span class="price-normal fs-3">{{ formatPrice(product.originalPrice) }}</span>
              </div>
            </div>

            <div class="admin-panel">
              <h3>📋 Mô tả sản phẩm</h3>
              <p style="color: var(--text-muted); line-height: 1.8;">{{ product.content || 'Chưa có mô tả' }}</p>
            </div>

            <div class="mt-3" style="color: var(--text-muted); font-size: 0.85rem;">
              📅 Ngày tạo: {{ new Date(product.createdDate).toLocaleDateString('vi-VN') }}
            </div>
          </div>
        </div>
      </div>
    </div>

    <div v-else class="text-center py-5">
      <p class="text-muted fs-5">Không tìm thấy sản phẩm</p>
      <router-link class="btn btn-primary mt-2" to="/">Về trang chủ</router-link>
    </div>
  </div>
</template>

<script setup>
import { ref, computed, onMounted } from 'vue'
import { useRoute } from 'vue-router'
import { getProduct } from '../services/api'

const route = useRoute()
const product = ref(null)
const loading = ref(true)

const formatPrice = (price) => {
  return new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(price)
}

const discount = computed(() => {
  if (!product.value?.salePrice) return 0
  return Math.round((1 - product.value.salePrice / product.value.originalPrice) * 100)
})

onMounted(async () => {
  try {
    const res = await getProduct(route.params.id)
    product.value = res.data
  } catch (e) {
    console.error('Failed to load product', e)
  } finally {
    loading.value = false
  }
})
</script>

<template>
  <div>
    <!-- Hero -->
    <section class="hero">
      <div class="container">
        <h1>🛍️ Chào mừng đến Mini E-Commerce</h1>
        <p class="mt-2">Khám phá hàng ngàn sản phẩm chất lượng với giá tốt nhất</p>
      </div>
    </section>

    <div class="container py-4">
      <!-- Loading -->
      <div v-if="loading" class="spinner-wrapper">
        <div class="spinner-custom"></div>
      </div>

      <!-- Product Carousel -->
      <div v-else>
        <h2 class="section-title">Sản phẩm nổi bật</h2>
        <div class="carousel-wrapper mb-5">
          <button class="carousel-btn prev" @click="scrollCarousel(-1)">‹</button>
          <div class="carousel-track" ref="carouselTrack" :style="{ transform: `translateX(-${scrollPos}px)` }">
            <div v-for="product in products" :key="product.id" class="product-card" @click="goToProduct(product.id)">
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
          <button class="carousel-btn next" @click="scrollCarousel(1)">›</button>
        </div>

        <!-- All Products Grid -->
        <h2 class="section-title">Tất cả sản phẩm</h2>
        <div class="row g-4">
          <div v-for="product in products" :key="'grid-' + product.id" class="col-6 col-md-4 col-lg-3">
            <div class="product-card" @click="goToProduct(product.id)">
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
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted } from 'vue'
import { useRouter } from 'vue-router'
import { getProducts } from '../services/api'

const router = useRouter()
const products = ref([])
const loading = ref(true)
const scrollPos = ref(0)

const formatPrice = (price) => {
  return new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(price)
}

const goToProduct = (id) => {
  router.push(`/product/${id}`)
}

const scrollCarousel = (direction) => {
  const step = 300
  const maxScroll = Math.max(0, products.value.length * 296 - 900)
  scrollPos.value = Math.max(0, Math.min(scrollPos.value + direction * step, maxScroll))
}

onMounted(async () => {
  try {
    const res = await getProducts()
    products.value = res.data
  } catch (e) {
    console.error('Failed to load products', e)
  } finally {
    loading.value = false
  }
})
</script>

<template>
  <div>
    <!-- Toast notifications -->
    <div class="toast-container">
      <div v-for="(toast, i) in toasts" :key="i" :class="['toast-item', toast.type]">
        {{ toast.message }}
      </div>
    </div>

    <!-- Navbar -->
    <nav class="navbar navbar-expand-lg navbar-custom sticky-top">
      <div class="container">
        <router-link class="navbar-brand" to="/">🛒 Electro shop</router-link>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav">
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNav">
          <ul class="navbar-nav ms-auto">
            <li class="nav-item">
              <router-link class="nav-link" to="/">Trang chủ</router-link>
            </li>
            <li class="nav-item dropdown" v-if="categories.length">
              <a class="nav-link dropdown-toggle" href="#" data-bs-toggle="dropdown">Danh mục</a>
              <ul class="dropdown-menu">
                <li v-for="cat in categories" :key="cat.id">
                  <router-link class="dropdown-item" :to="`/category/${cat.id}`">{{ cat.name }}</router-link>
                </li>
              </ul>
            </li>
            <li class="nav-item">
              <router-link class="nav-link" to="/admin">⚙️ Admin</router-link>
            </li>
          </ul>
        </div>
      </div>
    </nav>

    <!-- Router View -->
    <router-view @show-toast="showToast" />

    <!-- Footer -->
    <footer class="footer">
      <div class="container">
        <p>© Electro shop. Built with using Vue 3 + ASP.NET Core</p>
      </div>
    </footer>
  </div>
</template>

<script setup>
import { ref, onMounted } from 'vue'
import { getCategories } from './services/api'

const categories = ref([])
const toasts = ref([])

const showToast = (message, type = 'success') => {
  toasts.value.push({ message, type })
  setTimeout(() => toasts.value.shift(), 3000)
}

onMounted(async () => {
  try {
    const res = await getCategories()
    categories.value = res.data
  } catch (e) {
    console.error('Failed to load categories', e)
  }
})
</script>

import { createRouter, createWebHistory } from 'vue-router'
import Home from '../views/Home.vue'
import Category from '../views/Category.vue'
import Product from '../views/Product.vue'
import Admin from '../views/Admin.vue'

const routes = [
    { path: '/', name: 'Home', component: Home },
    { path: '/category/:id', name: 'Category', component: Category },
    { path: '/product/:id', name: 'Product', component: Product },
    { path: '/admin', name: 'Admin', component: Admin }
]

const router = createRouter({
    history: createWebHistory(),
    routes
})

export default router

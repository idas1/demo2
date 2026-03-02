import axios from 'axios'

const api = axios.create({
    baseURL: '/api',
    headers: {
        'Accept': 'application/json'
    }
})

// ===== Products =====
export const getProducts = () => api.get('/products')
export const getProduct = (id) => api.get(`/products/${id}`)
export const getProductsByCategory = (categoryId, sortBy = '') => {
    const params = sortBy ? { sortBy } : {}
    return api.get(`/products/by-category/${categoryId}`, { params })
}

export const createProduct = (formData) => api.post('/products', formData, {
    headers: { 'Content-Type': 'multipart/form-data' }
})

export const updateProduct = (id, formData) => api.put(`/products/${id}`, formData, {
    headers: { 'Content-Type': 'multipart/form-data' }
})

export const deleteProduct = (id) => api.delete(`/products/${id}`)

// ===== Categories =====
export const getCategories = () => api.get('/categories')
export const createCategory = (data) => api.post('/categories', data)
export const updateCategory = (id, data) => api.put(`/categories/${id}`, data)
export const deleteCategory = (id) => api.delete(`/categories/${id}`)

export default api

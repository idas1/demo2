import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import 'bootstrap/dist/css/bootstrap.min.css'
import 'bootstrap/dist/js/bootstrap.bundle.min.js'
import './assets/main.css'
import 'aos/dist/aos.css'
import '@fortawesome/fontawesome-free/css/all.min.css'
import AOS from 'aos'

const app = createApp(App)
app.use(router)
app.mount('#app')

AOS.init({
    duration: 1200,
    offset: 100,
    easing: 'ease-in-out',
    once: true,
})

<template>
  <div id="home">
    <!-- Hero -->
    <section class="secBanner bg-white">
      <div class="container">
        <div class="landing1">
          <div class="owl-item active">
            <div class="item">
              <div class="row">
                <div class="col-md-7 col-12">
                  <div class="hero-slider__item__info">
                    <div class="hero-slider__item__info_title color-pink">
                      <span class="wk-editable-text" id="secBanner-text2">Macbook M3 đã có mặt tại shop</span>
                    </div>
                    <div class="hero-slider__item__info_desc">
                      <span class="wk-editable-text" id="secBanner-text3">
                        Macbook M3 với hiệu năng vượt trội và thiết kế sang trọng, là trợ thủ đắc lực cho công việc và giải trí của bạn.
                      </span>
                    </div>
                    <div class="hero-slider__item__info_btn">
                      <a class="wk-editable-link" id="secBanner-link1" href="/category/2">
                        <button class="btn bg-pink btn-animate undefined overflow-hidden">
                          <span class="btn__txt wk-text">Xem chi tiết</span>
                          <span class="btn__icon">
                            <svg height="1em" viewbox="0 0 24 24" width="1em" xmlns="http://www.w3.org/2000/svg" fill="currentColor" stroke="currentColor" stroke-width="0">
                              <path d="M21.822 7.431A1 1 0 0 0 21 7H7.333L6.179 4.23A1.994 1.994 0 0 0 4.333 3H2v2h2.333l4.744 11.385A1 1 0 0 0 10 17h8c.417 0 .79-.259.937-.648l3-8a1 1 0 0 0-.115-.921zM17.307 15h-6.64l-2.5-6h11.39l-2.25 6z"></path>
                              <circle cx="10.5" cy="19.5" r="1.5"></circle>
                              <circle cx="17.5" cy="19.5" r="1.5"></circle>
                            </svg>
                          </span>
                        </button>
                      </a>
                    </div>
                  </div>
                </div>
                <div class="col-md-5 col-12">
                  <div class="hero-slider__item__image pt-md-5 pt0">
                    <div class="shape bg-pink"></div>
                    <div class="img-wrap">
                      <div class="dad-block-130">
                        <img class="child-block wk-editable-image" id="secBanner-img1" :src="imagebg">
                      </div>
                    </div>
                  </div>
                </div>
              </div>
          </div>
          </div>
        </div>
      </div>
    </section>
    <section class="features-section">
      <div class="feature-item">
          <div class="feature-icon">
              <svg viewBox="0 0 24 24"><path d="M20 8h-3V4H3c-1.1 0-2 .9-2 2v11h2c0 1.66 1.34 3 3 3s3-1.34 3-3h6c0 1.66 1.34 3 3 3s3-1.34 3-3h2v-5l-3-4zM6 18.5c-.83 0-1.5-.67-1.5-1.5s.67-1.5 1.5-1.5 1.5.67 1.5 1.5-.67 1.5-1.5 1.5zm13.5-9l1.96 2.5H17V9.5h2.5zm-1.5 9c-.83 0-1.5-.67-1.5-1.5s.67-1.5 1.5-1.5 1.5.67 1.5 1.5-.67 1.5-1.5 1.5z"/></svg>
          </div>
          <div class="feature-text">
              <h4>Free Shipping</h4>
              <p>On all orders above $500</p>
          </div>
      </div>

      <div class="feature-item">
          <div class="feature-icon">
              <svg viewBox="0 0 24 24"><path d="M11.4 1.02C6.62 1.33 2.8 5.22 2.53 10c-.31 5.46 4.05 10 9.47 10h.5c.55 0 1-.45 1-1v-5c0-.55-.45-1-1-1h-1.5V10c0-2.87 2.1-5.43 4.95-5.86 2.59-.39 4.84 1.25 5.4 3.53.15.6.24 1.3.15 2.13-.19 1.76-1.07 3.12-2.22 4.04-.37.3-.87.12-1-.34l-.46-1.56c-.09-.31.05-.64.33-.79.6-.32 1.05-.88 1.25-1.55.19-.66.1-1.33-.23-1.89-.54-.92-1.58-1.46-2.65-1.39-1.52.1-2.73 1.3-2.85 2.83-.06.84.21 1.61.71 2.18.27.31.25.79-.06 1.06l-1.34 1.18c-.34.3-.87.27-1.16-.06-1.05-1.22-1.61-2.8-1.58-4.47.05-3.08 2.58-5.61 5.66-5.61.34 0 .68.03 1.01.09C15.93 2.13 13.79 1 12 1c-.2 0-.4.01-.6.02zM21 15v3c0 1.1-.9 2-2 2h-1c-1.1 0-2-.9-2-2v-3c0-1.1.9-2 2-2h1c1.1 0 2 .9 2 2z"/></svg>
          </div>
          <div class="feature-text">
              <h4>24/7 Support</h4>
              <p>Expert help whenever you need</p>
          </div>
      </div>

      <div class="feature-item">
          <div class="feature-icon">
              <svg viewBox="0 0 24 24"><path d="M12 1L3 5v6c0 5.55 3.84 10.74 9 12 5.16-1.26 9-6.45 9-12V5l-9-4zm-2 16l-4-4 1.41-1.41L10 14.17l6.59-6.59L18 9l-8 8z"/></svg>
          </div>
          <div class="feature-text">
              <h4>Genuine Products</h4>
              <p>100% authentic tech guaranteed</p>
          </div>
      </div>
    </section>
    <section class="hero">
      <div class="container">
        <h1>Chào mừng đến với Electro shop</h1>
        <p class="mt-2">Khám phá hàng ngàn sản phẩm chất lượng với giá tốt nhất</p>
      </div>
    </section>
    <section class="zen-care-section py-5 overflow-hidden">
      <div class="container">
        <div class="row align-items-center" style="row-gap:40px">
          <div class="col-lg-6 position-relative image-col">
            <div class="image-wrapper">
              <div class="main-image-left" data-aos="fade-up" data-aos-delay="200">
                <img alt="Massage đá nóng" class="img-fluid rounded-4 shadow wk-editable-image" id="zen-care-image" src="https://i.pinimg.com/736x/68/da/5c/68da5c85d86532c63b5790e057e6d957.jpg">
                <!-- <div class="experience-badge" data-aos="fade" data-aos-delay="1000">
                  <div class="badge-icon-bg">
                    <img src="https://cdn.hstatic.net/themes/200000989925/1001392765/14/index_about_banner_2.jpg?v=75">
                  </div>
                </div> -->
              </div>
              <div class="secondary-image-center rounded-4 shadow" data-aos="fade-down" data-aos-delay="200">
                <img alt="Massage lưng" class="img-fluid rounded-4 wk-editable-image" id="zen-care-image1" src="https://i.pinimg.com/736x/a7/94/ea/a794ea3115924929442b731d062d521d.jpg">
              </div>
            </div>
          </div>
          <div class="col-lg-6 content-col">
            <div class="content-box ps-lg-5">
              <div class="zen-header mb-4" data-aos="fade-left" data-aos-delay="200">
                <div class="logo-small-icon">
                  <img src="https://media.istockphoto.com/id/1365436662/vi/anh/quan-h%E1%BB%87-%C4%91%E1%BB%91i-t%C3%A1c-th%C3%A0nh-c%C3%B4ng.jpg?s=612x612&w=0&k=20&c=n5JxVRZYvD8lg3jESMPBMCEQRMXSpNZBhffVSMWZENY=">
                </div>
                <span class="company-name wk-editable-text" id="zen-care-text">VỀ CHÚNG TÔI</span>
              </div>
              <div class="main-title" data-aos="fade-left" data-aos-delay="400">
                <span class="wk-editable-text" id="zen-care-text1">Hành trình đưa bạn đến với sự </span>
                <strong class="wk-editable-text" id="zen-care-text2">tin tưởng</strong>
              </div>
              <p class="description mb-4 wk-editable-text" data-aos="fade-left" data-aos-delay="800" id="zen-care-text3">
                Khám phá các sản phẩm công nghệ chính hãng và dịch vụ tư vấn tận tâm tại cửa hàng của chúng tôi, nơi chúng tôi kết hợp hiệu năng mạnh mẽ và thiết kế hiện đại để nâng tầm trải nghiệm số và tối ưu công việc của bạn.
              </p>
              <div class="d-flex justify-content-center align-items-center flex-wrap">
                <!-- <ul class="feature-list list-unstyled mb-md-5 mb-4" data-aos="fade-up" data-aos-delay="1000">
                  <li>
                    <i class="fa-solid fa-check feature-icon"></i>
                    <span class="wk-editable-text" id="zen-care-text4">Công nghệ đỉnh cao – Kết nối tương lai</span>
                  </li>
                  <li>
                    <i class="fa-solid fa-check feature-icon"></i>
                    <span class="wk-editable-text" id="zen-care-text5">Sản phẩm chính hãng – Giá trị bền vững</span>
                  </li>
                  <li>
                    <i class="fa-solid fa-check feature-icon"></i>
                    <span class="wk-editable-text" id="zen-care-text6">Đội ngũ chuyên nghiệp – Hỗ trợ tận tâm</span>
                  </li>
                </ul> -->
                <div class="side-image-right rounded-4 shadow mb-4 d-none" data-aos="fade-up" data-aos-delay="1200">
                  <img alt="Chăm sóc da mặt" class="img-fluid rounded-4 wk-editable-image" id="zen-care-image2" src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTDKZ43DtvY_vgjoogF9MobWowxKnsgibtQ1w&s">
                </div>
              </div>
              <div class="contact-cta d-flex align-items-center justify-content-between p-4 rounded-4 mt-3" data-aos="fade-up" data-aos-delay="1400">
                <div class="contact-info">
                  <span class="contact-label wk-editable-text" id="zen-care-text7">Liên hệ tư vấn</span>
                  <p class="phone-number">0123456789</p>
                </div>
                <a class="btn-cta text-decoration-none wk-editable-link" id="zen-care-link" href="#">
                  <span class="btn-text wk-text">Xem thêm</span>
                  <span class="btn-icon">
                    <i class="fa-solid fa-arrow-right mb-0"></i>
                  </span>
                </a>
              </div>
            </div>
          </div>
        </div>
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

        <!-- banner QC -->
        <section class="bannerQC my-md-5 my-4">
          <div class="bannerQC-content">
              <h2>Upgrade Your Setup.<br><span class="highlight">Save up to 30%.</span></h2>
              <p>Join our exclusive tech membership and get early access to flash sales and premium warranty extensions.</p>
              <div class="bannerQC-buttons">
                  <button class="btn btn-dark">Claim Discount</button>
                  <button class="btn btn-light">Learn More</button>
              </div>
          </div>
          
          <div class="bannerQC-promo">
              <div class="promo-card">
                  <p class="promo-subtitle">SUMMER PROMO CODE</p>
                  <h3 class="promo-code">TECH30</h3>
                  <hr class="promo-divider">
                  <p class="promo-date">VALID UNTIL JULY 31ST</p>
              </div>
          </div>
      </section>

        <!-- All Products Grid -->
        <h2 class="section-title">Tất cả sản phẩm</h2>
        <div class="row g-4">
          <div v-for="product in products" :key="'grid-' + product.id" class="col-6 col-md-4 col-lg-3">
            <div class="product-card" @click="goToProduct(product.id)">
              <img :src="product.imagePath || 'https://placehold.co/600x600' " :alt="product.name" />
              <div class="card-body">
                <h5 class="card-title">{{ product.name }}</h5>
                <div v-if="product.salePrice" class="d-flex flex-wrap">
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
import imagebg from '../image/macbook-air-m3.png'

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

<style scoped>
#home {
  @keyframes progress_bar_fill {
    0% {
      background-position: 0 0;
    }
    100% {
      background-position: 40px 0;
    }
  }
  @keyframes marquee {
    100% {
      transform: translate3d(-50%, 0, 0);
    }
  }
}
.secBanner {
  aspect-ratio: 2 / 1;
  .color-red {
    color: var(--do_chu_dao);
  }
  .bg-red {
    background: var(--do_chu_dao);
    .btn__txt {
      color: #fff;
    }
  }
  .color-pink {
    color: var(--bg-dark)
  }
  .bg-pink {
    background: var(--bg-dark);
    .btn__txt {
      color: #fff;
    }
  }
  .landing1 {
    #owl-nav1 {
      top: unset;
      bottom: 15%;
      width: 100px;
      left: 50%;
      transform: translateX(-50%);
      .owl-prev {
        left: 3%;
        box-shadow: none;
        background-color: transparent;
        color: var(--do_chu_dao);
        font-size: 65px;
        padding: 0;
      }
      .owl-next {
        right: 3%;
        box-shadow: none;
        background-color: transparent;
        color: var(--do_chu_dao);
        font-size: 65px;
        padding: 0;
      }
      
    }
    .item {
      .hero-slider__item__info {
        display: flex;
        flex-direction: column;
        height: 100%;
        justify-content: center;
        .hero-slider__item__info_title {
          font-size: 46px;
          font-weight: 600;
          line-height: 87px;
          overflow: hidden;
          margin-bottom: 60px;
          span {
            display: block;
            -webkit-transform: translateY(-100%);
            transform: translateY(-100%);
            transition: -webkit-transform 0.5s ease;
            transition: transform 0.5s ease;
            transition: transform 0.5s ease, -webkit-transform 0.5s ease;
            transition-delay: 0.5s;
          }
        }
        .hero-slider__item__info_desc {
          color: #8d8d8d;
          font-size: 20px;
          line-height: 29px;
          overflow: hidden;
          margin-bottom: 60px;
          span {
            display: block;
            -webkit-transform: translateY(-100%);
            transform: translateY(-100%);
            transition: -webkit-transform 0.5s ease;
            transition: transform 0.5s ease;
            transition: transform 0.5s ease, -webkit-transform 0.5s ease;
            transition-delay: 0.5s;
          }
        }
        .hero-slider__item__info_btn {
          overflow: hidden;
          button {
            display: block;
            -webkit-transform: translateY(-100%);
            transform: translateY(-100%);
            transition: -webkit-transform 0.5s ease;
            transition: transform 0.5s ease;
            transition: transform 0.5s ease, -webkit-transform 0.5s ease;
            padding: 0;
            transition-delay: 0.5s;

            .btn__txt {
              font-weight: bold;
              padding: 13px 26px;
              color: #fff;
              display: block;
              transition: -webkit-transform 0.5s ease;
              transition: transform 0.5s ease;
              transition: transform 0.5s ease, -webkit-transform 0.5s ease;
            }
            .btn__icon {
              align-items: center;
              display: flex;
              font-size: 2rem;
              height: 100%;
              justify-content: center;
              left: 0;
              position: absolute;
              top: 0;
              -webkit-transform: translateX(-100%);
              transform: translateX(-100%);
              transition: transform 0.5s ease;
              transition: transform 0.5s ease, -webkit-transform 0.5s ease;
              width: 100%;
              svg {
                fill: #fff;
              }
            }
          }
          .btn-animate {
            &:hover {
              .btn__txt {
                -webkit-transform: translateX(100%);
                transform: translateX(100%);
              }
              .btn__icon {
                -webkit-transform: translateX(0%);
                transform: translateX(0%);
              }
            }
          }
        }
      }
      .hero-slider__item__image {
        min-height: 90vh;
        position: relative;
        .shape {
          -webkit-animation: borderr 10s infinite;
          animation: borderr 10s infinite;
          border-radius: 58% 42% 38% 62% / 42% 55% 45% 58%;
          height: 472px;
          position: absolute;
          right: 0;
          top: 50%;
          -webkit-transform: translateY(-50%);
          transform: translateY(-50%);
          transition: border-radius 13s ease;
          width: 472px;
          @media (max-width: 768px) {
            width: 100%;
          }
        }
        .img-wrap {
          
          position: absolute;
          top: 50%;
          left: 50%;
          width: 100%;
          height: auto;
          transform: translate(-50%, -50%);
          @media (max-width:768px) {
            position: unset;
            transform: none;
          }
        }
        @keyframes border {
          0% {
            border-radius: 58% 42% 38% 62% / 42% 55% 45% 58%;
          }
          50% {
            border-radius: 31% 69% 59% 41% / 28% 24% 76% 72%;
          }
          100% {
            border-radius: 58% 42% 38% 62% / 42% 55% 45% 58%;
          }
        }
        @media (max-width:768px) {
          min-height: auto;
          .shape{
            display: none;
          }
        }
      }
    }

    .owl-item.active {
      .item {
        .hero-slider__item__info {
          .hero-slider__item__info_title {
            span {
              -webkit-transform: translateY(0%);
              transform: translateY(0%);
            }
          }
        }
        .hero-slider__item__info_desc {
          span {
            -webkit-transform: translateY(0%);
            transform: translateY(0%);
          }
        }
        .hero-slider__item__info_btn {
          button {
            -webkit-transform: translateY(0%);
            transform: translateY(0%);
          }
        }
        
      }
    }
  }
  @media (max-width: 768px) {
    padding: 40px 0;
    .landing1 {
      .item {
        .hero-slider__item__info {
          .hero-slider__item__info_title {
            font-size: 32px;
            line-height: 40px;
            margin-bottom: 30px;
          }
          .hero-slider__item__info_desc {
            margin-bottom: 30px;
          }
        }
      }
    }
  }
}
.zen-care-section {
  background-color: #ffffff;
  padding: 60px 0;

  @keyframes infiniterotate {
    0% {
      transform: rotate(0deg);
    }

    100% {
      transform: rotate(360deg);
    }
  }

  .image-col {
    min-height: 700px;

    @media (max-width: 991px) {
      min-height: auto;
      margin-bottom: 40px;
    }

    .image-wrapper {
      position: relative;
      height: 100%;
      display: flex;
      justify-content: flex-end;
      padding: 0 15px 5% 0;

      .main-image-left {
        position: absolute;
        bottom: -50%;
        left: 0;
        width: 55%;
        max-width: 450px;
        box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
        z-index: 2;
        img {
          border-radius: 30px;
        }

        @media (max-width: 991px) {
          max-width: none;
        }

        img {
          display: block;
          width: 100%;
          height: auto;
          object-fit: cover;
        }

        .experience-badge {
          position: absolute;
          bottom: 80px;
          right: -66px;
          width: 120px;
          height: 120px;
          background-color: var(--do_chu_dao);
          border-radius: 50%;
          display: flex;
          flex-direction: column;
          align-items: center;
          justify-content: center;
          text-align: center;
          font-size: 14px;
          line-height: 1.2;
          padding: 10px;
          transform: rotate(-15deg);

          @media (max-width: 991px) {
            bottom: unset;
            top: -100px;
            right: 80px;
            width: 80px;
            height: 80px;
          }

          .badge-text {
            color: #1a8a1b;
            font-weight: bold;
          }

          .badge-icon-bg {
            width: 60px;
            height: 60px;
            background-color: #fff;
            border-radius: 50%;
            display: flex;
            align-items: center;
            justify-content: center;
            margin-top: 5px;

            img {
              animation: infiniterotate 25s infinite linear;
            }
          }
        }
      }

      .secondary-image-center {
        position: relative;
        width: 60%;
        max-width: 380px;
        z-index: 1;

        @media (max-width: 991px) {
          max-width: none;
        }

        img {
          width: 100%;
          height: auto;
          object-fit: cover;
          border-radius: 30px;
        }
      }
    }
  }

  .content-col {
    color: #333333;

    .content-box {
      padding: 30px;
      @media (max-width: 768px) {
        padding: 50px 0;
      }

      .zen-header {
        display: flex;
        align-items: center;
        margin-bottom: 10px;

        .logo-small-icon {
          width: 30px;
          height: 30px;
          background-color: #eff8f2;
          border-radius: 50%;
          display: flex;
          align-items: center;
          justify-content: center;
          margin-right: 8px;

          i {
            color: #1a8a1b;
            font-size: 16px;
          }
        }

        .company-name {
          color: #1a8a1b;
          font-weight: 500;
          font-size: 14px;
          letter-spacing: 1px;
        }
      }

      .main-title {
        color: #4b271a;
        font-size: 2.5rem;
        font-weight: 300;
        line-height: 1.2;
        margin-bottom: 20px;

        strong {
          font-weight: 600;
          color: #1a8a1b;
        }
        @media (max-width: 768px) {
          font-size: 32px;
        }
      }

      .description {
        font-size: 1rem;
        line-height: 1.6;
      }

      .feature-list {
        li {
          margin-bottom: 10px;
          font-size: 0.95rem;

          .feature-icon {
            color: #1a8a1b;
            margin-right: 10px;
            font-size: 1.1rem;
          }
        }
      }

      .side-image-right {
        max-width: 350px;
        margin-left: auto;
        border-radius: 30px;
        overflow: hidden;
        box-shadow: 0 5px 15px rgba(0, 0, 0, 0.05);

        @media (max-width: 991px) {
          margin-left: 0;
        }

        img {
          width: 100%;
          height: auto;
          object-fit: cover;
        }
      }

      .contact-cta {
        background-color: #eff8f2;
        border-radius: 30px;

        .contact-info {
          .contact-label {
            display: block;
            font-size: 0.9rem;
            color: #333333;
            opacity: 0.8;
          }

          .phone-number {
            margin: 0;
            font-size: 1.4rem;
            font-weight: 700;
            color: #1a8a1b;
            @media (max-width: 768px) {
              font-size: 13px;
            }
          }
        }

        .btn-cta {
          background-color: #1a8a1b;
          color: #ffffff;
          padding: 10px 20px;
          border-radius: 50px;
          display: flex;
          align-items: center;
          transition: background-color 0.3s;

          &:hover {
            background-color: #8c372c;
          }

          .btn-text {
            font-weight: 600;
            margin-right: 10px;
            @media (max-width: 768px) {
              font-size: 13px;
            }
          }

          .btn-icon {
            width: 30px;
            height: 30px;
            background-color: #ffffff;
            color: #1a8a1b;
            border-radius: 50%;
            display: flex;
            align-items: center;
            justify-content: center;
          }
        }
      }
    }
  }
}
.features-section {
            background-color: #ffffff;
            padding: 40px 10%;
            display: flex;
            justify-content: space-between;
            align-items: center;
            flex-wrap: wrap;
            gap: 20px;
            border-bottom: 1px solid #e5e5e5;
        

        .feature-item {
            display: flex;
            align-items: center;
            gap: 15px;
            flex: 1;
            min-width: 250px;
        }

        .feature-icon {
            background-color: #e8f8ee;
            color: #27c964;
            width: 50px;
            height: 50px;
            border-radius: 12px;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .feature-icon svg {
            width: 24px;
            height: 24px;
            fill: currentColor;
        }

        .feature-text h4 {
            color: #1a1a1a;
            font-size: 1rem;
            margin-bottom: 4px;
        }

        .feature-text p {
            color: #666666;
            font-size: 0.9rem;
        }
        @media (max-width: 900px){
          .features-section {
                flex-direction: column;
                align-items: flex-start;
                padding: 40px 5%;
            }
        }
      }
.bannerQC {
            /* Background gradient mô phỏng thiết kế */
            background: linear-gradient(110deg, #12ea76 0%, #8ae652 50%, #e9ce3c 100%);
            border-radius: 20px;
            width: 100%;
            /* max-width: 1000px; */
            padding: 50px 60px;
            display: flex;
            justify-content: space-between;
            align-items: center;
            position: relative;
            overflow: hidden;
            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.05);
        

        /* Tạo dải màu vát chéo mờ mờ ở nền phải */
        .bannerQC::after {
            content: '';
            position: absolute;
            top: 0;
            right: 0;
            bottom: 0;
            width: 60%;
            background: linear-gradient(to bottom right, transparent 40%, rgba(220, 200, 50, 0.15) 40%);
            pointer-events: none;
            z-index: 1;
        }

        .bannerQC-content {
            flex: 1;
            max-width: 500px;
            z-index: 2;
        }

        .bannerQC-content h2 {
            font-size: 3.2rem;
            font-weight: 900;
            line-height: 1.1;
            color: #121526; /* Xanh đen đậm */
            margin-bottom: 20px;
            letter-spacing: -1px;
        }

        .bannerQC-content h2 .highlight {
            color: #1c8a43; /* Xanh lá đậm */
        }

        .bannerQC-content p {
            color: #1c8a43;
            font-size: 1.1rem;
            line-height: 1.5;
            margin-bottom: 30px;
            font-weight: 500;
        }

        .bannerQC-buttons {
            display: flex;
            gap: 15px;
        }

        .btn {
            padding: 12px 26px;
            border-radius: 8px;
            font-size: 1rem;
            font-weight: 700;
            cursor: pointer;
            border: none;
            transition: transform 0.2s ease, box-shadow 0.2s ease;
        }

        .btn:hover {
            transform: translateY(-2px);
        }

        .btn-dark {
            background-color: #121526;
            color: #ffffff;
            box-shadow: 0 8px 15px rgba(18, 21, 38, 0.2);
        }

        .btn-light {
            background-color: #ffffff;
            color: #121526;
        }

        /* --- Promo Card (Thẻ bên phải) --- */
        .bannerQC-promo {
            z-index: 2;
            padding-right: 20px;
        }

        .promo-card {
            background: rgba(229, 235, 142, 0.7); /* Màu vàng chanh nhạt hơi trong suốt */
            backdrop-filter: blur(5px);
            padding: 35px 40px;
            border-radius: 16px;
            text-align: center;
            transform: rotate(-6deg); /* Xoay nghiêng thẻ */
            box-shadow: 0 15px 25px rgba(0, 0, 0, 0.05);
            border: 1px solid rgba(255, 255, 255, 0.2);
        }

        .promo-subtitle {
            font-size: 0.8rem;
            font-weight: 800;
            color: #121526;
            letter-spacing: 1px;
            margin-bottom: 10px;
        }

        .promo-code {
            font-size: 2.8rem;
            font-weight: 900;
            color: #121526;
            letter-spacing: -1px;
            margin-bottom: 10px;
        }

        .promo-divider {
            width: 40px;
            height: 4px;
            background-color: #121526;
            border: none;
            border-radius: 2px;
            margin: 0 auto 15px auto;
        }

        .promo-date {
            font-size: 0.7rem;
            font-weight: 700;
            color: #121526;
            opacity: 0.8;
        }

        /* --- Responsive cho màn hình nhỏ --- */
        @media (max-width: 850px) {
            .bannerQC {
                flex-direction: column;
                padding: 40px 30px;
                text-align: center;
                gap: 50px;
            }

            .bannerQC-content p {
                margin: 0 auto 30px auto;
            }

            .bannerQC-buttons {
                justify-content: center;
            }

            .bannerQC-promo {
                padding-right: 0;
            }
        }
      }
</style>
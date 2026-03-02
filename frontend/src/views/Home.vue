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
    <section class="hero">
      <div class="container">
        <h1>Chào mừng đến Mini E-Commerce</h1>
        <p class="mt-2">Khám phá hàng ngàn sản phẩm chất lượng với giá tốt nhất</p>
      </div>
    </section>
    <section class="zen-care-section py-5 overflow-hidden">
      <div class="container">
        <div class="row align-items-center" style="row-gap:40px">
          <div class="col-lg-6 position-relative image-col">
            <div class="image-wrapper">
              <div class="main-image-left" data-aos="fade-up" data-aos-delay="200">
                <img alt="Massage đá nóng" class="img-fluid rounded-4 shadow wk-editable-image" id="zen-care-image" src="https://media.istockphoto.com/id/935659716/vi/anh/c%E1%BA%ADn-c%E1%BA%A3nh-c%C3%A1i-b%E1%BA%AFt-tay-trong-v%C4%83n-ph%C3%B2ng.jpg?s=612x612&w=0&k=20&c=vhAIU-UzvCa670u8jTzOn29H31_AX3TFY1hJheudTOY=">
                <!-- <div class="experience-badge" data-aos="fade" data-aos-delay="1000">
                  <div class="badge-icon-bg">
                    <img src="https://cdn.hstatic.net/themes/200000989925/1001392765/14/index_about_banner_2.jpg?v=75">
                  </div>
                </div> -->
              </div>
              <div class="secondary-image-center rounded-4 shadow" data-aos="fade-down" data-aos-delay="200">
                <img alt="Massage lưng" class="img-fluid rounded-4 wk-editable-image" id="zen-care-image1" src="https://media.istockphoto.com/id/1365436662/vi/anh/quan-h%E1%BB%87-%C4%91%E1%BB%91i-t%C3%A1c-th%C3%A0nh-c%C3%B4ng.jpg?s=612x612&w=0&k=20&c=n5JxVRZYvD8lg3jESMPBMCEQRMXSpNZBhffVSMWZENY=">
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
                <ul class="feature-list list-unstyled mb-md-5 mb-4" data-aos="fade-up" data-aos-delay="1000">
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
                </ul>
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

        <!-- All Products Grid -->
        <h2 class="section-title">Tất cả sản phẩm</h2>
        <div class="row g-4">
          <div v-for="product in products" :key="'grid-' + product.id" class="col-6 col-md-4 col-lg-3">
            <div class="product-card" @click="goToProduct(product.id)">
              <img :src="product.imagePath || 'https://placehold.co/600x600' " :alt="product.name" />
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
          -webkit-transform: scale(0) rotate(65deg);
          transform: scale(0) rotate(65deg);
          transition: -webkit-transform 0.5s
            cubic-bezier(0.175, 0.885, 0.32, 1.275);
          transition: transform 0.5s cubic-bezier(0.175, 0.885, 0.32, 1.275);
          transition: transform 0.5s cubic-bezier(0.175, 0.885, 0.32, 1.275),
            -webkit-transform 0.5s cubic-bezier(0.175, 0.885, 0.32, 1.275);
          transition-delay: 0.5s;
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
        .hero-slider__item__image {
          .img-wrap {
            -webkit-transform: scale(1) rotate(0);
            transform: scale(1) rotate(0);
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
        bottom: -24%;
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
        padding: 30px 0;
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
</style>
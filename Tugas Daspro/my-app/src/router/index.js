import Vue from 'vue'
import VueRouter from 'vue-router'
import WebLogin from '../components/WebLogin.vue'
import WebHome from '../components/WebHome.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/home',
    name: 'home',
    component: WebHome
  },
  {
    path: '/about',
    name: 'about',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/AboutView.vue')
  },
  {
    path: '/login',
    name: 'login',
    component: WebLogin
  }
]

const router = new VueRouter({
  routes
})

export default router

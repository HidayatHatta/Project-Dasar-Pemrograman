import Vue from 'vue'
import Vuetify from 'vuetify/lib'
import App from './App.vue'
import vuetify from './plugins/vuetify'

Vue.use(Vuetify)

import 'vuetify/dist/vuetify.min.css'
import router from './router'

Vue.config.productionTip = false

new Vue({
  vuetify,
  router,
  render: h => h(App)
}).$mount('#app')

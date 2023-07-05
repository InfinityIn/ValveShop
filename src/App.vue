<template>
  <div class="main-container">
    <div class="menus-container">
      <MainMenu/>
      <FollowedMenu />
      <ProductPropertyView />
      <ControlView />
    </div>
    <div class="order-list-container">
      <OrderListView/>
    </div>
    
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import MainMenu from './components/MainMenu.vue';
import FollowedMenu from './components/FollowedMenu.vue';
import ProductPropertyView from './components/ProductPropertyView.vue';
import ControlView from './components/ControlView.vue';
import OrderListView from './components/OrderListView.vue';

export default defineComponent({
  name: 'App',
  components: {
    OrderListView,
    MainMenu,
    FollowedMenu,
    ProductPropertyView,
    ControlView
}
});
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}

.main-container {
  display: block;
  align-items: center;
  align-self: stretch;
}

.menus-container {
  display: flex;
}

.order-list-container {
  align-items: center;
  min-height: 30%;
  border:10px;
  border-color: #2c3e50;
}
</style>

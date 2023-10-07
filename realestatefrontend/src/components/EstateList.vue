<script setup lang="ts">
import EstateComponent from './Estate.vue';
import LoadingComponent from './Loading.vue';

import { getEstates, Estate } from '../api'
import { ref, onMounted } from 'vue'

const MIN_PRICE = ref<number>(import.meta.env.VITE_MIN_PRICE as number);
const MAX_PRICE = ref<number>(import.meta.env.VITE_MAX_PRICE as number);
const MIN_SIZE = ref<number>(import.meta.env.VITE_MIN_SIZE as number);
const MIN_FLOOR = ref<number>(import.meta.env.VITE_MIN_FLOOR as number);
const MAX_YEAR = ref<number>(import.meta.env.VITE_MAX_YEAR as number);
const MAX_ROOMS = ref<number>(import.meta.env.VITE_MAX_ROOMS as number);

const estates = ref<Estate[]>([]);
const minPrice = ref<number>(MIN_PRICE.value);
const maxPrice = ref<number>(MAX_PRICE.value);
const minSize = ref<number>(MIN_SIZE.value);
const maxYear = ref<number>(MAX_YEAR.value);
const maxRooms = ref<number>(MAX_ROOMS.value);
const minFloor = ref<number>(MIN_FLOOR.value);
const search = ref<string>('');

const loading = ref<boolean>(true);

onMounted(async () => {
    try {
        setTimeout(() => {
            loading.value = false;
        }, 200);
        estates.value = await getEstates('');
    } catch (error) {
        console.log(error)
    }
});

function nullCheck(value: string) {
    if (value == null) {
        return false;
    }
    if (value == '') {
        return false;
    }
    if (value == undefined) {
        return false;
    }
    return true;
}

async function fetchEstates() {
    loading.value = true;

    if (minPrice.value < MIN_PRICE.value || !nullCheck(minPrice.value.toString())) {
        minPrice.value = MIN_PRICE.value;
    }

    if (maxPrice.value > MAX_PRICE.value || !nullCheck(maxPrice.value.toString())) {
        maxPrice.value = MAX_PRICE.value;
    }

    if (minSize.value < MIN_SIZE.value || !nullCheck(minSize.value.toString())) {
        minSize.value = MIN_SIZE.value;
    }

    if (maxYear.value > MAX_YEAR.value || !nullCheck(maxYear.value.toString())) {
        maxYear.value = MAX_YEAR.value;
    }

    if (maxRooms.value > MAX_ROOMS.value || !nullCheck(maxRooms.value.toString())) {
        maxRooms.value = MAX_ROOMS.value;
    }

    if (minFloor.value < MIN_FLOOR.value || !nullCheck(minFloor.value.toString())) {
        minFloor.value = MIN_FLOOR.value;
    }


    let query = `search=${search.value}&minPrice=${minPrice.value}&maxPrice=${maxPrice.value}&minSize=${minSize.value}&maxYear=${maxYear.value}&maxRooms=${maxRooms.value}&minFloor=${minFloor.value}`;
    setTimeout(() => {
        loading.value = false;
    }, 200);
    estates.value = await getEstates(query);
}
</script>

<template>
    <div class="row">
        <h1>Real Estates</h1>
        <div class="row mb-4">
            <div class="col">
                <label for="query" class="form-label">Query</label>
                <input type="text" class="form-control" placeholder="Search Title Or Description" v-model="search">
            </div>
        </div>
        <div class="row mb-4">
            <div class="col-lg-2 col-sm-4">
                <label for="minPrice" class="form-label">Min Price</label>
                <input type="number" :min="MIN_PRICE" class="form-control" placeholder="Min Price" v-model="minPrice">
            </div>
            <div class="col-lg-2 col-sm-4">
                <label for="maxPrice" class="form-label">Max Price (₺)</label>
                <input type="number" :min="MIN_PRICE" class="form-control" placeholder="Max Price" v-model="maxPrice">
            </div>
            <div class="col-lg-2 col-sm-4">
                <label for="minSize" class="form-label">Min Size (m2)</label>
                <input type="number" class="form-control" placeholder="Min Size" v-model="minSize">
            </div>
            <div class="col-lg-2 col-sm-4">
                <label for="maxYear" class="form-label">Max Year</label>
                <input type="number" class="form-control" placeholder="Max Year" v-model="maxYear">
            </div>
            <div class="col-lg-2 col-sm-4">
                <label for="maxRooms" class="form-label">Max Rooms</label>
                <input type="number" class="form-control" placeholder="Max Rooms" v-model="maxRooms">
            </div>
            <div class="col-lg-2 col-sm-4">
                <label for="minFloor" class="form-label">Min Floor</label>
                <input type="number" class="form-control" placeholder="Min Floor" v-model="minFloor">
            </div>
        </div>
        <div class="row mb-4">
            <div class="col">
                <button type="button" class="btn btn-primary float-end" @click="fetchEstates">Search</button>
            </div>
        </div>
        <div class="row">
            <div v-if="loading" class="col text-center">
                <LoadingComponent />
            </div>
            <template v-if="loading == false && estates.length" v-for="estate in estates">
                <EstateComponent :estate="estate" />
            </template>
            <template v-else>
                <div class="alert alert-warning" role="alert">
                    No estate found!
                </div>
            </template>

        </div>
    </div>
</template>

<style scoped></style>
<script setup lang="ts">
import { Estate } from '../api';
defineProps<{ estate: Estate }>();
</script>

<template>
    <div class="col-lg-4 col-sm-6">
        <div class="card">
            <div :id="`carousel-${estate.id}`" class="carousel slide">
                <div class="carousel-inner">
                    <div :class="`carousel-item ${index == 0 ? 'active' : ''}`" v-for="(img, index) in estate.images">
                        <img width="600" loading="lazy" height="400" :src="img.url" class="d-block w-100"
                            :alt="index.toString()">
                    </div>
                </div>
                <button class="carousel-control-prev" type="button" :data-bs-target="`#carousel-${estate.id}`"
                    data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Previous</span>
                </button>
                <button class="carousel-control-next" type="button" :data-bs-target="`#carousel-${estate.id}`"
                    data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Next</span>
                </button>
            </div>
            <div class="card-body">
                <table class="table">
                    <tbody>
                        <tr>
                            <th scope="col">Title</th>
                            <td>{{ estate.title }} </td>
                        </tr>
                        <tr>
                            <th scope="col">Description</th>
                            <td>{{ estate.description }} </td>
                        </tr>
                        <tr>
                            <th scope="col">Price</th>
                            <td>{{ estate.price }} ₺</td>
                        </tr>
                        <tr>
                            <th scope="col">Size</th>
                            <td>{{ estate.size }} m2</td>
                        </tr>
                        <tr>
                            <th scope="col">Rooms</th>
                            <td>{{ estate.rooms }}</td>
                        </tr>
                        <tr>
                            <th scope="col">Floor</th>
                            <td>{{ estate.floor }}</td>
                        </tr>
                        <tr>
                            <th scope="col">Year</th>
                            <td>{{ estate.year }}</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>

    </div>
</template>

<style scoped>
.carousel-control-next-icon,
.carousel-control-prev-icon {

    width: 40px;
    height: 40px;
    background-color: #00000068;
    background-size: 50%, 100%;
    border-radius: 50%;
    border: 1px solid #fff;
}
</style>
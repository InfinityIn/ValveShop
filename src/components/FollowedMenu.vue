<template>
    <div class="post">
        <div v-if="loading" class="loading">
            Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationvue">https://aka.ms/jspsintegrationvue</a> for more details.
        </div>

        <div v-if="post" class="content">
            <table>
                <thead>
                    <tr>
                        <th>Второстепенное меню</th>                                              
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="mainMenuItem in post" :key="mainMenuItem.name">
                      <td>{{ mainMenuItem.name }}</td>                                             
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</template>

<script lang="ts">
    import { defineComponent } from 'vue';

  type MainMenuItems = {
        id: number,
        name: string,
        priority: number
    }[];

    interface Data {
        loading: boolean,
        post: null | MainMenuItems
    }

    export default defineComponent({
        data(): Data {
            return {
                loading: false,
                post: null
            };
        },
        created() {
            // fetch the data when the view is created and the data is
            // already being observed
            this.fetchData();
        },
        watch: {
            // call again the method if the route changes
            '$route': 'fetchData'
        },
        methods: {
            fetchData(): void {
                this.post = null;
                this.loading = true;

                fetch('mainmenu')
                    .then(r => r.json())
                    .then(json => {
                        this.post = json as MainMenuItems;
                        this.loading = false;
                        return;
                    });
            }
        },
    });
</script>
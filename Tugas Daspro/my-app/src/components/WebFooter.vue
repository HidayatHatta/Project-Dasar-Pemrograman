<template>
    <v-footer id="footer" dark height="auto">
        <v-card class="flex" flat tile>
            <v-card-title id="card" class="green darken-4">
                <strong class="subheading">Get connected with us on social networks!</strong>
                <v-spacer></v-spacer>
                <v-btn v-for="icon in icons" :key="icon" class="mx-3" dark icon>
                    <v-icon size="24px">{{ icon }}</v-icon>
                </v-btn>
            </v-card-title>

            <v-card-actions id="cardA" class="grey darken-3 justify-center">
                ©2018 —<strong>Universitas Riau</strong>
            </v-card-actions>
        </v-card>
    </v-footer>
</template>
<script>
export default {
    data: () => ({
        icons: [
            'fab fa-facebook',
            'fab fa-twitter',
            'fab fa-google-plus',
            'fab fa-linkedin',
            'fab fa-instagram'
        ]
    })
}
</script>

<style>
#footer {
    background-color: darkgreen;
    bottom: 0;
    position: absolute;
    width: 100%;
    justify-content: center;
}

#card {
    background-color: darkgreen;
}
#cardA {
    justify-content: center;
}
</style>
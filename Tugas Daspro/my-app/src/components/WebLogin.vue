<template>
    <v-container>
        <v-form v-model="valid">
            <v-text-field
            v-model="name"
            :rules="namaRules"
            :counter="10"
            label="Name"
            required
            ></v-text-field>
            <v-text-field
            v-model="email"
            :rules="emailRules"
            label="E-mail"
            required
            ></v-text-field>
            <v-text-field
            v-model="pesan"
            label="Pesan"
            multi-line
            ></v-text-field>
        </v-form>
    </v-container>
</template>

<script>
    export default {
        data: () => ({
            valid: false,
            name: '',
            namaRules: [
                v => !!v || 'Name is required',
                v => v.length <= 10 || 'Name must be less than 10 characters'
            ],
            pesan: ''
        })
    }
</script>
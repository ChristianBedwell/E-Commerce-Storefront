var app = new Vue({
    el: '#app',
    data: {
        editing: false,
        loading: false,
        username: "",
        password: ""
    },
    mounted() {
        // TODO: get all users
    },
    methods: {
        // TODO: using the text from the username and password fields, create a new user
        createUser() {
            this.loading = true;
            axios.post('/users', { username: this.username, password: this.password })
            .then(res => {
                console.log(res);
            })
            .catch(err => {
                console.log(err);
            })
            .then(() => {
                this.loading = false;
                this.editing = false;
            });
        },
        newUser() {
            this.editing = true;
            this.userModel.id = 0;
        },
        cancel() {
            this.editing = false;
        }
    }
});
var app = new Vue({
    el: '#app',
    data: {
        editing: false,
        loading: false,
        userModel: {
            username: "",
            password: "",
            role: ""
        },
        users: []
    },
    mounted() {
        this.getUsers();
    },
    methods: {
        // using the text from the username and password fields, create a new user
        createUser() {
            this.loading = true;
            axios.post('/users', this.userModel)
            .then(res => {
                console.log(res.data);
                this.users.push(res.data);
            })
            .catch(err => {
                console.log(err);
            })
            .then(() => {
                this.loading = false;
                this.editing = false;
            });
        },
        // get all existing users
        getUsers() {
            this.loading = true;
            axios.get('/users')
            .then(res => {
                console.log(res);
                this.users = res.data;
            })
            .catch(err => {
                console.log(err);
            })
            .then(() => {
                this.loading = false;
            });
        },
        newUser() {
            this.editing = true;
        },
        cancel() {
            this.editing = false;
        }
    }
});
var app = new Vue({
    el: '#app',
    data: {
        editing: false,
        loading: false,
        objectIndex: 0,
        userModel: {
            id: 0,
            username: "",
            password: ""
        },
        users: []
    },
    mounted() {
        this.getUsers();
    },
    methods: {
        // get an existing user by id
        getUser(id) {
            // TODO
        },
        // get all existing users
        getUsers() {
            // TODO
        },
        // create a new user
        createUser() {
            this.loading = true;
            axios.post('/users', { username: this.userModel.username, password: this.userModel.password })
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
        updateUser() {
            // TODO
        },
        // edits user at index
        editUser() {
            this.objectIndex = index;
            this.getUser(id);
            this.editing = true;
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
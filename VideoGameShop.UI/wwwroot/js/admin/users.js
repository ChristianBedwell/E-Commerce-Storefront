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
        // TODO: get an existing user by id
        getUser(id) {
            this.loading = true;
            axios.get('/users/' + id)
                .then(res => {
                    console.log(res);
                    var user = res.data;
                    this.userModel = {
                        id: user.id,
                        username: user.username,
                        password: user.password
                    };
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        // TODO: get all existing users
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
        // TODO: create a new user
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
        // TODO: update an existing user
        updateUser() {
            this.loading = true;
            axios.put('/users', this.userModel)
                .then(res => {
                    console.log(res.data);
                    this.users.splice(this.objectIndex, 1, res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
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
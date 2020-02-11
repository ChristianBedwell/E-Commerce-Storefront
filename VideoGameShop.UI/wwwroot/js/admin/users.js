var app = new Vue({
    el: '#app',
    data: {
        editing: false,
        loading: false,
        objectIndex: 0,
        userModel: {
            id: 0,
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
        // get an existing user by id
        getUser(id) {
            this.loading = true;
            axios.get('/users/' + id)
                .then(res => {
                    console.log(res);
                    var user = res.data;
                    this.userModel = {
                        id: user.id,
                        username: user.username,
                        password: user.password,
                        role: user.role
                    };
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
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
        // update an existing user's credentials
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
        // delete an existing user
        deleteUser(id, index) {
            this.loading = true;
            axios.delete('/users/' + id)
            .then(res => {
                console.log(res);
                this.users.splice(index, 1);
            })
            .catch(err => {
                console.log(err);
            })
            .then(() => {
                this.loading = false;
            });
        },
        editUser(id, index) {
            this.objectIndex = index;
            this.getUser(id);
            this.editing = true;
        },
        newUser() {
            this.editing = true;
            this.userModel.id = 0;
            this.userModel.username = "";
            this.userModel.password = "";
            this.userModel.role = "";
        },
        cancel() {
            this.editing = false;
        }
    }
});
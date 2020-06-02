
Vue.filter("formatNumber", function (value) {
    return separate(value);
});

var app = new Vue({

    el: "#app",
    data: {
        listSelectionProduct:[],
        selectedProduct:null,
        listProduct: null,
    },
    methods: {
      
        onChange(event) {

            let has = true;
            this.listSelectionProduct.forEach(i => {

                if (i.Id == this.selectedProduct.Id ) {
                    has = false;
                    i.count++;
                }

            });
            if (has) {

                this.listSelectionProduct.push(this.selectedProduct);

            }


        }


    },
    computed: {
 

    },


    created: function () {
  

    },


    mounted() {
        axios.post('/RegisterFactor/GetProducts')
    .then(response => {
        this.listProduct = response.data.listProduct;
        for (let index = 0; index < this.listProduct.length; index++) {
            Vue.set(this.listProduct[index], `count`, 1)

        }
    })

    },
})
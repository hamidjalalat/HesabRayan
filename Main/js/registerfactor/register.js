
Vue.filter("formatNumber", function (value) {
    return separate(value);
});

var app = new Vue({

    el: "#app",
    data: {
        customer:null,
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


        },
        plus: function (item) {
            item.count++;

        },

        minus: function (item) {

            if (item.count > 1) {

                item.count--

            }
            else {
                const index = this.listSelectionProduct.indexOf(item);
                if (index > -1) {
                    this.listSelectionProduct.splice(index, 1);
                }
            }


        },

        getSubTotal: function (item) {
            let result =
                item.count * item.Price

            return result
        },

        getTotal: function () {

            let total = 0

            for (let index = 0; index < this.listSelectionProduct.length; index++) {

                let currentItem = this.listSelectionProduct[index]

                total +=
                    this.getSubTotal(currentItem)

            }
            this.listSelectionProduct.Total = total;
            return total

        },


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
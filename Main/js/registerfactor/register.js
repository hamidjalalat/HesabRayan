
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
      
        addProduct :function(e){
            if (e.keyCode === 13) {
                let has = true;
                this.listSelectionProduct.forEach(i => {

                    if (i.Id == this.selectedProduct.Id) {
                        has = false;
                        i.count++;
                    }

                });
                if (has) {

                    this.listSelectionProduct.push(this.selectedProduct);

                }
            }
        },
        newFactor(){
            location.reload();
        },
        redirectToAction() {
            console.log(this.customer);
            if (this.customer==null) {
                $(`div#valid`).modal();
                retrun;
            }
            
            if (this.listSelectionProduct.length != 0) {
                $('#checkfinal').hide();
                $(`div#loadingModal`).modal({ backdrop: false, keyboard: false, });
                let parameter = { jsonFactor: JSON.stringify(this.listSelectionProduct), nameCustomer: this.customer };
                axios.post('/RegisterFactor/GetRegisterFactor', parameter)
                 .then(response => {
                     if (response.data) {
                         $(`div#success`).modal();

                     }
                     else {
                         
                         $(`div#errormodal`).modal();
                     }

                 })
         .catch(error => {

             $(`div#errormodal`).modal();
         })
         .finally(() => {
             $('#checkfinal').show();
             $(`div#loadingModal`).modal(`hide`)
         })
            }
            else {
                $(`div#messagemodal`).modal();
            }

        },
        plus: function (item) {
            item.count++;

        },
        remove: function (item) {
            let id = this.listSelectionProduct.indexOf(item);
            item.count = 1;
            this.listSelectionProduct.splice(id, 1);

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
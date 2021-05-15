var app = new Vue({
    el: '#app',
    data: {
        breweries: [],
        searchCriteria: '',
        currentEntity: null,
        isSearching: false
    },

    mounted: function() {
        $('modal').on('show.bs.modal', function () {
            $('focus').trigger('focus');
        });
    },

    methods: {
        searchBreweries: searchBreweries,
        getBreweriesByType: getBreweriesByType,
        getBreweriesByCity: getBreweriesByCity,
        breweryModal: breweryModal
    }
});

function searchBreweries() {
    app.breweries = [];
    app.isSearching = true;

    $.ajax({
        type: "POST",
        url: "/Brewery/Search",
        data: JSON.stringify(app.searchCriteria),
        contentType: "application/json"
    }).done(function (result) {
        app.breweries = result;
    }).always(function () {
        app.isSearching = false;
    })
};

function getBreweriesByType(type) {
    app.breweries = [];
    app.isSearching = true;

    $.ajax({
        type: "POST",
        url: "/Brewery/GetByBreweryType",
        data: JSON.stringify(type),
        contentType: "application/json"
    }).done(function (result) {
        app.breweries = result;
    }).always(function () {
        app.isSearching = false;
    })
};

function getBreweriesByCity(city) {
    app.breweries = [];
    app.isSearching = true;

    $.ajax({
        type: "POST",
        url: "/Brewery/GetByCity",
        data: JSON.stringify(city),
        contentType: "application/json"
    }).done(function (result) {
        app.breweries = result;
    }).always(function () {
        app.isSearching = false;
    })
};

function breweryModal(brewery) {
    app.currentEntity = JSON.parse(JSON.stringify(brewery));
    showBreweryModal();
};



function showBreweryModal() {
    $('#breweryModal').modal({
        backdrop: 'static',
        keyboard: false
    });
};
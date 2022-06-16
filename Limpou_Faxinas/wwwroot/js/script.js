// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function requestApi(url) {
    let request = new XMLHttpRequest();
    request.open('GET', url, false);
    request.send();
    return request.responseText;
}

function createP({ high, name }) {
    const p = document.createElement("p");
    const textP = `${name}: R$${high}`;
    p.innerHTML = textP;
    return p;
}

function returnApi() {
    //api de dados: https://economia.awesomeapi.com.br/json/all
    const coinsData = requestApi('https://economia.awesomeapi.com.br/json/all');
    const dataJson = JSON.parse(coinsData);
    const currencyValue = Object.values(dataJson);
    const divCurrency = document.getElementById('orcamento_paises');
    const filterCurrency = currencyValue.filter((currency) => currency.code === 'USD' || currency.code === 'EUR');
    console.log(filterCurrency);
    filterCurrency.forEach(currency => {
        console.log(currency);
        let p = createP(currency)
        divCurrency.appendChild(p);
    });
}
returnApi();


function AbrirSecao(secao) {
    window.open("" + secao + "", "_parent");
}
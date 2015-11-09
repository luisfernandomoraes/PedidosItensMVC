function salvarPedido() {
    debugger;

    //data
    var data = $("#data").val();

    //Cliente
    var cliente = $("#cliente").val();

    //Valor
    var valor = $("#valor").val();

    var token = $('input[name="__RequestVerificationToken"]').val();
    var tokenador = $('form[action="/Pedido/Create" input[name="__RequestVerificationToken"]').val();
    var headers = {};
    var headersadr = {};

    headers["__RequestVerificationToken"] = token;
    headersadr["__RequestVerificationToken"] = tokenador;


    //Gravar
    var url = "/Pedido/Create";


    $.ajax({
        url: url,
        type: "POST",
        headers: headersadr,
        data: { Id: 0, Data: data, Cliente: cliente, Valor: valor, __RequestVerificationToken: token },
        success: function (data) {
            if (data.Resultado > 0) {
                debugger;
                listarItens(data.Resultado);
            }
        }
    });
}

function listarItens(idPedido) {
    var url = "/Itens/ListarItens";
    $.ajax({
        url: url,
        type: "GET",
        data: { id: idPedido },
        datatype: "html",
        success: function (data) {
            debugger;
            var divItens = $("#divItens");
            divItens.empty();
            divItens.show();
            divItens.html(data);
        }
    });
}

function salvarItens() {
    var quantidade = $("#Quantidade").val();
    var produto = $("#Produto").val();
    var valorunitario = $("#ValorUnitario").val();
    var idPedido = $("#idPedido").val();

    var url = "../Itens/SalvarItens";

    $.ajax({
        url: url,
        data: { quantidade: quantidade, produto: produto, valorunitario: valorunitario, idPedido: idPedido },
        type: "GET",
        datatype: "html",
        success: function (data) {
            if (data.Resultado > 0)
                listarItens(data.Resultado);
        }
    });
}
// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


/* verificação de campos vazio do formulário */

function exibirMensagemErro(campo, mensagem) {
    var mensagemErro = document.getElementById("mensagens-erro");
    mensagemErro.textContent = mensagem;
    campo.classList.add("campo-erro");
}

function limparMensagemErro(campo) {
    var mensagemErro = document.getElementById("mensagens-erro");
    mensagemErro.textContent = "";
    campo.classList.remove("campo-erro");
}

function validaCampos(e) {
    var nome = document.getElementById("nome");
    var telefone = document.getElementById("telefone");
    var dataEmprestimo = document.getElementById("dataEmprestimo");
    var dataDevolucao = document.getElementById("dataDevolucao");
    var livroEmprestado = document.getElementById("livroEmprestado");

    if (nome.value === "") {
        exibirMensagemErro(nome, "Informe o nome!");
        e.preventDefault();
        return false;
    } else {
        limparMensagemErro(nome);
    }

    if (telefone.value === "") {
        exibirMensagemErro(telefone, "Informe o telefone!");
        e.preventDefault();
        return false;
    } else {
        limparMensagemErro(telefone);
    }

    if (dataEmprestimo.value === "") {
        exibirMensagemErro(dataEmprestimo, "Informe a data de empréstimo!");
        e.preventDefault();
        return false;
    } else {
        limparMensagemErro(dataEmprestimo);
    }

    if (dataDevolucao.value === "") {
        exibirMensagemErro(dataDevolucao, "Informe a data de devolução!");
        e.preventDefault();
        return false;
    } else {
        limparMensagemErro(dataDevolucao);
    }

    if (livroEmprestado.value === "") {
        exibirMensagemErro(livroEmprestado, "Informe o livro!");
        e.preventDefault();
        return false;
    } else {
        limparMensagemErro(livroEmprestado);
    }

    return true;
}

var elForm = document.getElementById("formEmprestimo");
elForm.addEventListener("submit", validaCampos);

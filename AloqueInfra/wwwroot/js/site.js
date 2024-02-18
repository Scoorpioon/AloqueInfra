const valorAlocacao = document.getElementById("ValorAlocacao");
const valorFechado = document.getElementById("ValorFechado");

console.log(valorFechado);

valorFechado.addEventListener('change', (acao) => {
    console.log(acao);

    opcaoSelecionada == true ? valorAlocacao.disabled = true : valorAlocacao.disabled = false;
};
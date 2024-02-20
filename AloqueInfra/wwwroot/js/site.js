const valorAlocacao = document.getElementById("ValorAlocacao");
const valorFechado = document.getElementById("ValorFechado");
const valorAlocacaoAutomatico = document.getElementById("ValorAlocacaoAutomatico");
const labelPreencher = document.getElementById("campoPreencher");
const labelAutomatico = document.getElementById("campoAutomatico");
const selecaoFuncionario = document.getElementById("Funcionario");

valorAlocacaoAutomatico.style.visibility = "hidden", labelAutomatico.style.visibility = "hidden";
valorAlocacaoAutomatico.disabled = true;

valorFechado.addEventListener('change', (acao) => {
    let opcaoSelecionada = valorFechado.value;
    console.log(opcaoSelecionada);

    if (valorAlocacao.disabled) {
        valorAlocacao.style.visibility = "visible", labelPreencher.style.visibility = "visible";
        valorAlocacao.disabled = false;

        valorAlocacaoAutomatico.style.visibility = "hidden", labelAutomatico.style.visibility = "hidden";
        valorAlocacaoAutomatico.disabled = true;
    } else {
        valorAlocacao.style.visibility = "hidden", labelPreencher.style.visibility = "hidden";
        valorAlocacao.disabled = true;

        valorAlocacaoAutomatico.style.visibility = "visible", labelAutomatico.style.visibility = "visible";
        valorAlocacaoAutomatico.disabled = false;
    }
});

selecaoFuncionario.addEventListener('change', () => {
    let valorSelecionado = selecaoFuncionario.selectedIndex;
    let opcaoSelecionada = selecaoFuncionario.options[valorSelecionado];
    let data = opcaoSelecionada.getAttribute("data-valor");

    valorAlocacaoAutomatico.value = opcaoSelecionada.dataset.valor;
});
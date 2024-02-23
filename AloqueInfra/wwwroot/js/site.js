const valorAlocacao = document.getElementById("ValorAlocacao");
const valorFechado = document.getElementById("ValorFechado");
const valorAlocacaoAutomatico = document.getElementById("ValorAlocacaoAutomatico");
const labelPreencher = document.getElementById("campoPreencher");
const labelAutomatico = document.getElementById("campoAutomatico");
const selecaoFuncionario = document.getElementById("Funcionario");
let dataInicial = document.getElementById("DataInicial");
let dataFinal = document.getElementById("DataFinal");
let campoDias = document.getElementById("QuantidadeDias");

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

    console.log("campo funcionário{RecursoModelo} alterado para " + opcaoSelecionada.dataset.valor);

    valorAlocacaoAutomatico.value = opcaoSelecionada.dataset.valor;
});

dataInicial.addEventListener('change', () => {
    // pega a data completa e transforma em uma lista, no qual você pode selecionar o ano, mês e dia por index.
    let dataCompleta = dataInicial.value.split('-');
    //console.log(`Data completa: ${dataCompleta}`);

    //console.log(`Dia: ${dataCompleta[2]}`);
});

dataFinal.addEventListener('change', () => {
    let dataInicialSplitada = dataInicial.value.split('-');
    let dataFinalSplitada = dataFinal.value.split('-');
    let anoInicial = Number(dataInicialSplitada[0]), anoFinal = Number(dataFinalSplitada[0]);
    let mesInicial = Number(dataInicialSplitada[1]), mesFinal = Number(dataFinalSplitada[1]);
    let diaInicial = Number(dataInicialSplitada[2]), diaFinal = Number(dataFinalSplitada[2]);
    let quantidadeDeDias = -1;
    let indiceFinal, indiceInicial;

    if (dataInicial.value == "") {
        console.log('DATA INICIAL NÃO PREENCHIDA');
        dataInicial.style.border = "1px solid red";
    } else {
        dataInicial.style.border = "1px solid #ced4da";

        if (anoInicial > anoFinal || mesInicial > mesFinal && anoInicial == anoFinal || diaInicial > diaFinal && mesInicial == mesFinal && anoInicial == anoFinal ) {
            dataInicial.style.border = "1px solid red";
            console.log(`DATA INICIAL NÃO PODE SER ANTERIOR À FINAL`);
        } else {
            diaInicial > diaFinal ? indiceFinal = diaFinal : indiceFinal = diaInicial;
            let quantidadeDeMeses = -1;
            let quantidadeDeAnos = -1;

            for (let i = mesInicial; i <= mesFinal; i++) {
                quantidadeDeMeses++
                quantidadeDeMeses > 0 ? console.log('diferença de meses: ' + quantidadeDeMeses) : false;
            }

            for (let i = anoInicial; i <= anoFinal; i++) {
                quantidadeDeAnos++
                quantidadeDeAnos > 0 ? console.log('diferença de anos: ' + quantidadeDeAnos) : false;
            }

            indiceFinal == diaInicial ? indiceInicial = diaFinal : indiceInicial = diaInicial;

            for(let i = indiceInicial; i <= indiceFinal; i++) {
                quantidadeDeDias += 1;
                console.log("Número: " + quantidadeDeDias)

                if (i == diaFinal && mesFinal > mesInicial || i == diaFinal && anoFinal > anoInicial) {
                    if(anoFinal > anoInicial) {
                        quantidadeDeDias = quantidadeDeDias + (30 * quantidadeDeMeses + 365 * quantidadeDeAnos);
                        console.log("Quantidade de dias final: " + quantidadeDeDias);
                        break;
                    }

                    quantidadeDeDias = quantidadeDeDias + (30 * quantidadeDeMeses);
                    console.log("Quantidade de dias final: " + quantidadeDeDias);
                    break;
                }
            }
        }
    }
});
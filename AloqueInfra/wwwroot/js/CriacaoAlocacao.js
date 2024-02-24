// Campos da página de criação das alocações
const valorAlocacao = document.getElementById("ValorAlocacao");
const valorFechado = document.getElementById("ValorFechado");
const valorAlocacaoAutomatico = document.getElementById("ValorAlocacaoAutomatico");
const labelPreencher = document.getElementById("campoPreencher");
const labelAutomatico = document.getElementById("campoAutomatico");
const selecaoFuncionario = document.getElementById("Funcionario");
let dataInicial = document.getElementById("DataInicial");
let dataFinal = document.getElementById("DataFinal");
let campoDias = document.getElementById("QuantidadeDias");
let erroAoSelecionar;

// Campos da página de exibição das alocações criadas
let valorFechadoTexto = document.getElementsByClassName('valorFechado');

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
    diferencaDeDatas('dataInicial');

    // pega a data completa e transforma em uma lista, no qual você pode selecionar o ano, mês e dia por index.
    let dataCompleta = dataInicial.value.split('-');
    //console.log(`Data completa: ${dataCompleta}`);

    //console.log(`Dia: ${dataCompleta[2]}`);
});

dataFinal.addEventListener('change', () => {
    diferencaDeDatas('dataFinal');
});

const diferencaDeDatas = (campoAlterado) => {
    let dataInicialSplitada = dataInicial.value.split('-');
    let dataFinalSplitada = dataFinal.value.split('-');
    let anoInicial = Number(dataInicialSplitada[0]), anoFinal = Number(dataFinalSplitada[0]);
    let mesInicial = Number(dataInicialSplitada[1]), mesFinal = Number(dataFinalSplitada[1]);
    let diaInicial = Number(dataInicialSplitada[2]), diaFinal = Number(dataFinalSplitada[2]);
    let quantidadeDeDias = -1;
    let indiceFinal, indiceInicial;

    if (erroAoSelecionar) {
        dataInicial.style.border = "1px solid #ced4da";
        campoDias.value = "";
        campoDias.style.color = 'black';

        erroAoSelecionar = false;
    }

    if (dataInicial.value == "") {
        dataInicial.style.border = "1px solid red";

        campoDias.value = "Data inválida";
        campoDias.style.color = 'red';

        console.log('DATA INICIAL NÃO PREENCHIDA');

        erroAoSelecionar = true;

    } else {
        if (campoAlterado == 'dataFinal' & anoInicial > anoFinal || mesInicial > mesFinal && anoInicial == anoFinal || diaInicial > diaFinal && mesInicial == mesFinal && anoInicial == anoFinal) {
            dataInicial.style.border = "1px solid red";

            campoDias.value = "Data inválida";
            campoDias.style.color = 'red';

            console.log(`DATA FINAL NÃO PODE SER ANTERIOR À INICIAL`);


            erroAoSelecionar = true;

        } else if(campoAlterado == 'dataFinal' || campoAlterado == 'dataInicial'){

            /*if(erroAoSelecionar) {
                campoDias.value = "";
                campoDias.style.color = 'black';

                console.log('eu fui ativado!')

                erroAoSelecionar = false;
            }*/

            diaInicial > diaFinal ? indiceFinal = diaInicial : indiceFinal = diaFinal;
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

            console.log(`Contagem será feita do número ${indiceInicial} até o ${indiceFinal}`);

            for (let i = indiceInicial; i <= indiceFinal; i++) {
                quantidadeDeDias++;
                //console.log("Número: " + quantidadeDeDias)

                if (i == indiceFinal && mesFinal > mesInicial || i == diaFinal && anoFinal > anoInicial) {
                    if (anoFinal > anoInicial) {
                        quantidadeDeDias = quantidadeDeDias + (30 * quantidadeDeMeses + 365 * quantidadeDeAnos);
                        campoDias.value = quantidadeDeDias;

                        break;
                    }

                    console.log('Quantidade de dias final:' + quantidadeDeDias);

                    quantidadeDeDias = quantidadeDeDias + 30 * quantidadeDeMeses;
                    campoDias.value = quantidadeDeDias;

                    console.log("Quantidade de dias final: " + quantidadeDeDias);
                    break;
                } else if(i == diaFinal){
                    campoDias.value = quantidadeDeDias;
                }
            }
        }
    }
}
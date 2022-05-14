function menuToggle() {
    const toggleMenu = document.querySelector('.menu');
    toggleMenu.classList.toggle('active')
}

function avancarModal(modal, etapa) {
    $(`#${modal}-passo-${etapa}`).hide();
    $(`#${modal}-passo-${etapa+1}`).show();
}

function voltarModal(modal, etapa) {
    if (etapa == 2) {
        $(`#${modal}-passo-${etapa}`).hide();
        $(`#${modal}-passo-${etapa - 1}`).show();
    }
    else {
        for (i = 1; i <= 3; i++) {
            $(`#${modal}-passo-${i}`).hide();
        }
        $(`#cadastro`).hide();
        $(`#login`).show();
    }
}

function alternarModalLoginCadastro() {
    $(`#login`).hide();
    $(`#cadastro`).show()
    $(`#cadastro-passo-1`).show()
}

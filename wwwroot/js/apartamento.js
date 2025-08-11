const apAddIcon = document.getElementById("addBlock");
const divCreate = document.getElementById("addDiv");

function CreateBlock() {
    divCreate.innerHTML = `
        <form>
            <div class="row mb-4">
                <label for="nameBlock" class="col-sm-4 col-form-label">Bloco: </label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="nameBlock" placeholder="nome do bloco">
                </div>
            </div>

            <!-- Container que receberá os apartamentos -->
            <div id="apartmentsContainer">
                <div class="row mb-4 apartment-row">
                    <label class="col-sm-4 col-form-label">Apartamento: </label>
                    <div class="col-sm-3">
                        <input type="text" class="form-control" placeholder="nº: ">                             
                    </div>
                    <div class="col-sm-4">
                        <div class="form-check pt-2">
                            <label class="form-check-label" for="Checkbox">Possui Vaga? </label>
                            <input class="form-check-input" type="checkbox value="option1" id="Checkbox">                            
                        </div>
                    </div>
                    <div class="col-sm-1">
                        <ion-icon name="add-circle" style="font-size:32px" class="pt-1 text-success add-apto"></ion-icon>
                    </div>
                </div>
            </div>

            <div class="row mb-4">
                <button type="submit" class="btn btn-success" id="SaveBlock">Salvar Bloco</button>
            </div>
        </form>
    `;

    // Adiciona evento ao primeiro botão de adicionar apartamento
    const firstAddIcon = divCreate.querySelector(".add-apto");
    firstAddIcon.addEventListener("click", addApartmentField);

    // Captura o botão de salvar e adiciona o evento
    const saveButton = divCreate.querySelector("#SaveBlock");
    saveButton.addEventListener("click", function (event) {
    event.preventDefault(); // Impede o envio padrão do formulário

    // Captura o nome do bloco
    const nameBlock = divCreate.querySelector("#nameBlock").value;

    // Captura todos os inputs de apartamento
    const apartmentInputs = divCreate.querySelectorAll(".apartment-row input");
    const apartments = [];

    apartmentInputs.forEach(input => {
        const value = input.value.trim();
        if (value !== "") {
            apartments.push(value);
        }
    });

    // Exibe os dados no console
    console.log("Nome do Bloco:", nameBlock);
    console.log("Apartamentos:", apartments);

    // Esconde o formulário
    divCreate.innerHTML = "";



    // Aqui você pode enviar os dados para o backend via fetch/AJAX se quiser
});
}

function addApartmentField() {
    const container = document.getElementById("apartmentsContainer");

    const newRow = document.createElement("div");
    newRow.classList.add("row", "mb-4", "apartment-row");

    newRow.innerHTML = `
        <label class="col-sm-4 col-form-label">Apartamento: </label>
        <div class="col-sm-3">
            <input type="text" class="form-control" placeholder="nº: ">                             
        </div>
        <div class="col-sm-4">
            <div class="form-check pt-2">
                <label class="form-check-label" for="Checkbox">Possui Vaga? </label>
                <input class="form-check-input" type="checkbox value="option1" id="Checkbox">                            
             </div>
        </div>
        <div class="col-sm-1">
            <ion-icon name="add-circle" style="font-size:32px" class="pt-1 text-success add-apto"></ion-icon>
        </div>
    `;

    // Adiciona evento ao novo ícone
    newRow.querySelector(".add-apto").addEventListener("click", addApartmentField);

    container.appendChild(newRow);
}

apAddIcon.addEventListener("click", CreateBlock);

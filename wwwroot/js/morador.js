function showInfo(action) {

  let conteudo = "";

  switch (action) {
    case 'add':
      conteudo = `
            <h5>Recursos disponíveis:</h5>
          <ul>
            <li>Cadastrar Novo Morador</li>
            <li>Cadastrar Novo Veículo</li>
            <li>Cadastrar Login e Senha</li>
          </ul>
          <p>Facilite a entrada de novos moradores com agilidade.</p>`;
      break;
    case 'edit':
      conteudo = `
            <h5>Recursos disponíveis:</h5>
          <ul>
            <li>Editar Dados do Morador</li>
            <li>Atualizar Informações de Veículo</li>
            <li>Alterar Senha de Acesso</li>
          </ul>
          <p>Mantenha os dados sempre atualizados.</p>`;
      break;
    case 'list':
      conteudo = `
            <h5>Recursos disponíveis:</h5>
          <ul>
            <li>Listar Todos os Moradores</li>
            <li>Visualizar Veículos Cadastrados</li>
            <li>Consultar Logins Ativos</li>
          </ul>
          <p>Tenha uma visão geral do condomínio.</p>`;
      break;
    case 'delete':
      conteudo = `
            <h5>Recursos disponíveis:</h5>
          <ul>
            <li>Excluir Morador</li>
            <li>Remover Veículo</li>
            <li>Desativar Login</li>
          </ul>
          <p>Gerencie acessos e cadastros com segurança.</p>`;
      break;

  }
  document.getElementById("dinamica").innerHTML = conteudo;
}

function resetInfo() {
  conteudo = "";
  document.getElementById("dinamica").innerHTML = conteudo;
}



const addIcon = document.getElementById('addIcon');
const cardBody = document.getElementById('cardBody');

addIcon.addEventListener('click', () => {

  cardBody.innerHTML = `
      <form id="vehicleForm">
        <div class="mb-2">
          <label>Placa do carro</label>
          <input type="text" class="form-control" id="placa" required>
        </div>
        <div class="mb-2">
          <label>Modelo</label>
          <input type="text" class="form-control" id="modelo" required>
        </div>
        <div class="mb-2">
          <label>Cor</label>
          <input type="text" class="form-control" id="cor" required>
        </div>
        <button type="submit" class="btn btn-success mt-2">Salvar</button>
      </form>
    `;


  const form = document.getElementById('vehicleForm');
  form.addEventListener('submit', function (e) {
    e.preventDefault();

    const placa = document.getElementById('placa').value;
    const modelo = document.getElementById('modelo').value;
    const cor = document.getElementById('cor').value;

    cardBody.innerHTML = `
    <div class="d-flex justify-content-between align-items-center gap-3 flex-wrap">
        <span><strong>Placa:</strong> <span>${placa}</span></span>
        <span><strong>Modelo:</strong> <span>${modelo}</span></span>
        <span><strong>Cor:</strong> <span>${cor}</span></span>
        <ion-icon name="remove" id="deleteBtn"></ion-icon>
    </div>
      `;


    document.getElementById('deleteBtn').addEventListener('click', () => {
      cardBody.innerHTML = '';
    });
  });
});
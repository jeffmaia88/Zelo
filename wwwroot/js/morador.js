function showInfo(action) {

    let conteudo = "";

    switch(action) {
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
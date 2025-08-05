
    const toggleBtn = document.getElementById('themeToggle');
    const themeIcon = document.getElementById('themeIcon');
    const body = document.body;

    // Inicializa com modo escuro
    body.classList.add('dark-mode');

    toggleBtn.addEventListener('click', () => {
        if (body.classList.contains('dark-mode')) {
            body.classList.remove('dark-mode');
            body.classList.add('light-mode');
            themeIcon.setAttribute('name', 'moon-outline');
        } else {
            body.classList.remove('light-mode');
            body.classList.add('dark-mode');
            themeIcon.setAttribute('name', 'sunny-outline');
        }
    });

# Tasks Project
<p>Este projeto tem como obejtivo aplicar conceitos de padrões de projetos e boas práticas de desenvolvimento.</p>

# Tecnologias
<p align="left">
  <img src="https://github.com/RicardoPaulino/tasks/assets/5764337/4aea0187-fbcf-4dcb-bd78-6f083e71ba79" width="180" />
  <img src="https://github.com/RicardoPaulino/tasks/assets/5764337/ad29633f-6f52-498e-a66a-8e0bd574394e" width="150" />
</p>

# Manual
## Criação do banco de dados

```
CREATE DATABASE MyTasks;
CREATE TABLE Tasks (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    StartDate DATETIME NOT NULL,
    EndDate DATETIME NOT NULL,
    Status NVARCHAR(50) NOT NULL
);
```


# 🔗 Links Úteis
<svg xmlns="http://www.w3.org/2000/svg" height="16" width="20" viewBox="0 0 640 512"><!--!Font Awesome Free 6.5.1 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license/free Copyright 2023 Fonticons, Inc.--><path opacity="1" fill="#1E3050" d="M349.9 236.3h-66.1v-59.4h66.1v59.4zm0-204.3h-66.1v60.7h66.1V32zm78.2 144.8H362v59.4h66.1v-59.4zm-156.3-72.1h-66.1v60.1h66.1v-60.1zm78.1 0h-66.1v60.1h66.1v-60.1zm276.8 100c-14.4-9.7-47.6-13.2-73.1-8.4-3.3-24-16.7-44.9-41.1-63.7l-14-9.3-9.3 14c-18.4 27.8-23.4 73.6-3.7 103.8-8.7 4.7-25.8 11.1-48.4 10.7H2.4c-8.7 50.8 5.8 116.8 44 162.1 37.1 43.9 92.7 66.2 165.4 66.2 157.4 0 273.9-72.5 328.4-204.2 21.4 .4 67.6 .1 91.3-45.2 1.5-2.5 6.6-13.2 8.5-17.1l-13.3-8.9zm-511.1-27.9h-66v59.4h66.1v-59.4zm78.1 0h-66.1v59.4h66.1v-59.4zm78.1 0h-66.1v59.4h66.1v-59.4zm-78.1-72.1h-66.1v60.1h66.1v-60.1z"/></svg>![docker](https://github.com/RicardoPaulino/tasks/assets/5764337/e613d314-9051-4c74-ab80-65cc0d39e4ed) [Docker](https://www.docker.com)






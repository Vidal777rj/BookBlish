# BookBlish
📚 API de Livros em C#

🧩 Contexto do Projeto
O objetivo deste projeto é desenvolver uma API em C# para registrar livros que tiveram impacto significativo na minha vida.
O desenvolvimento segue boas práticas de programação, priorizando escalabilidade, organização em camadas e facilidade de manutenção.

💡 Todo o backend foi construído sem o uso de inteligência artificial, com o propósito de demonstrar proficiência técnica e possibilitar melhorias e refatorações futuras à medida que evoluo na área de desenvolvimento backend.

⚙️ Requisitos Não Funcionais

🔁 Escalabilidade
Estrutura baseada em Repository Pattern.
Separação de camadas para facilitar manutenção e criação de testes unitários.

💾 Persistência de Dados
Banco de dados SQLite por ser leve e não exigir infraestrutura em nuvem.
Armazenamento de capas dos livros no AWS S3, permitindo reutilização do bucket em futuros projetos.

🧾 Documentação
Utilização do Swagger para testar endpoints e expor a API a recrutadores e colaboradores.

☁️ Deploy
Hospedagem na AWS, com API e frontend em serviços separados, garantindo isolamento, flexibilidade e escalabilidade.

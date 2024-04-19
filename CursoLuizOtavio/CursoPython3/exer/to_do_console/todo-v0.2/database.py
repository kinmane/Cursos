import sqlite3

# Função para criar o banco de dados e as tabelas
def criar_banco_de_dados():
    # Conecta ao banco de dados (se não existir, será criado)
    conexao = sqlite3.connect('database.db')
    cursor = conexao.cursor()
    
    # Cria a tabela de tarefas
    cursor.execute('''
        CREATE TABLE IF NOT EXISTS tarefas (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            titulo TEXT NOT NULL,
            descricao TEXT,
            concluido BOOLEAN NOT NULL DEFAULT 0
        )
    ''')
    
    # Salva as alterações e fecha a conexão
    conexao.commit()
    conexao.close()

# Chamada da função para criar o banco de dados e as tabelas
criar_banco_de_dados()

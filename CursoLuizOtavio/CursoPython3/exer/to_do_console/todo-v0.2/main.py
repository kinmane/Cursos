import sqlite3

def adicionar_tarefa(titulo, descricao):
    #Conecta ao banco de dados
    conexao = sqlite3.connect('database.db')
    cursor = conexao.cursor()
    
    #Insere a tarefa no banco de dados
    cursor.execute ("""INSERT INTO tarefas (titulo, descricao) VALUES (?, ?)""", (titulo, descricao))
    
    #Salva as alterações
    conexao.commit()
    conexao.close()
    
def listar_taferas():
    #Conecta ao banco de dados
    conexao = sqlite3.connect('database.db')
    cursor = conexao.cursor()
    
    #Seleciona todas as tarefas
    cursor.execute('''SELECT * FROM tarefas''')
    
    #Retorna as tarefas como lista
    tarefas = []
    for tarefa in cursor.fetchall():
        tarefas.append({
            'id': tarefa[0],
            'titulo': tarefa[1],
            'descricao': tarefa[2],
            'concluido': tarefa[3]
        })
    
    conexao.close()
    return tarefas

def concluir_tarefa(id):
    #Conecta ao banco de dados
    conexao = sqlite3.connect('database.db')
    cursor = conexao.cursor()
    
    #Atualiza o status da tarefa
    cursor.execute('''UPDATE tarefas SET concluido = 1 WHERE id = ?''', (id,))
    
    #Salva as alterações
    conexao.commit()
    conexao.close()
    
def remover_tarefa(id):
    #Conecta ao banco de dados
    conexao = sqlite3.connect('database.db')
    cursor = conexao.cursor()
    
    #Remove a tarefa
    cursor.execute('''DELETE FROM tarefas WHERE id = ?''', (id,))
    
    #Salva as alterações
    conexao.commit()
    conexao.close()
    
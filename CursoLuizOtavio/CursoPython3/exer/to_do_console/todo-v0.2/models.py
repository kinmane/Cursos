class Tarefa:
    def __init__(self, id, titulo, descricao, concluido):
        self.id = id
        self.titulo = titulo
        self.descricao = descricao
        self.concluido = concluido
        
    def __repr__(self):
        return f'<Tarefa (id={self.id}, titulo={self.titulo}, concluido={self.concluido})>'
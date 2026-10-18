using Godot;
using System;

public partial class CenaInfancia : Node2D
{
	private RichTextLabel textoDialogo;
	private Label nomeLocutor;
	private Button botaoSim;
	private Button botaoNao;
	private PanelContainer balaoPensamento;
	private RichTextLabel textoPensamento;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		textoDialogo = GetNode<RichTextLabel>("CanvasLayer2/DialogoUI/CaixaDialogo/TextoDialogo");
		nomeLocutor = GetNode<Label>("CanvasLayer2/DialogoUI/CaixaLocutor/NomeLocutor");
		botaoSim = GetNode<Button>("CanvasLayer2/DialogoUI/Opcoes/BotaoSim");
		botaoNao = GetNode<Button>("CanvasLayer2/DialogoUI/Opcoes/BotaoNao");
		balaoPensamento = GetNode<PanelContainer>("CanvasLayer2/DialogoUI/BalaoPensamento");
		textoPensamento = GetNode<RichTextLabel>("CanvasLayer2/DialogoUI/BalaoPensamento/TextoPensamento");

		textoDialogo.Text = "texto de teste";
		nomeLocutor.Text = "Protagonista";
		
		textoPensamento.Text = "";
		balaoPensamento.Hide();
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}

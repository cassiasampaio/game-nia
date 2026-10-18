using Godot;
using System;

public partial class CenaInfancia : Node2D
{
	private RichTextLabel textoDialogo;
	private Label nomeLocutor;
	private Button botaoSim;
	private Button botaoNao;
	private Control balaoPensamentoNao;
	private RichTextLabel textoPensamentoNao;
	private Label textoBalaoNao;
	private Label textoBalaoSim;
	
	private TextureRect imagemFundoNao;
	private TextureRect imagemFundoSim;
	
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		textoDialogo = GetNode<RichTextLabel>("CanvasLayer2/DialogoUI/CaixaDialogo/TextoDialogo");
		nomeLocutor = GetNode<Label>("CanvasLayer2/DialogoUI/CaixaLocutor/NomeLocutor");
		botaoSim = GetNode<Button>("CanvasLayer2/DialogoUI/Opcoes/BotaoSim");
		botaoNao = GetNode<Button>("CanvasLayer2/DialogoUI/Opcoes/BotaoNao");
		balaoPensamentoNao = GetNode<Control>("CanvasLayer2/DialogoUI/BalaoPensamentoNao");
		textoPensamentoNao = GetNode<RichTextLabel>("CanvasLayer2/DialogoUI/BalaoPensamentoNao/TextoPensamentoNao");
		imagemFundoNao = GetNode<TextureRect>("CanvasLayer/ImagemFundoNao");
		imagemFundoSim = GetNode<TextureRect>("CanvasLayer/ImagemFundoSim");
		textoBalaoNao = GetNode<Label>("CanvasLayer2/DialogoUI/Opcoes/BotaoNao/TextoBalaoNao");
		textoBalaoSim = GetNode<Label>("CanvasLayer2/DialogoUI/Opcoes/BotaoSim/TextoBalaoSim");
		
		textoDialogo.Text = "Ô Nia, vem cá! Teu cabelo é tão fofinho... só deixa a tia arrumar aqui que tá todo armado e feio, parece até que você tomou um susto.";
		nomeLocutor.Text = "Tia Júlia";
		
		textoPensamentoNao.Text = "Mas e se a titia  Júlia ficar triste?"; 
		
		textoBalaoNao.Text = "Tia Júlia, eu não gosto que fale assim do meu cabelo.";
		textoBalaoSim.Text = "Arruma, Tia Júlia! Eu não quero ficar feia.";

		
		balaoPensamentoNao.Hide();
		
		botaoNao.MouseEntered += MostrarPensamentoNao;
		botaoSim.MouseEntered += MostrarPensamentoSim;
		
		botaoNao.MouseExited += OcultarPensamentos;
		botaoSim.MouseExited += OcultarPensamentos;
		
		imagemFundoNao.Hide();
		imagemFundoSim.Hide();
		
		imagemFundoNao.MouseFilter = Control.MouseFilterEnum.Ignore;
		imagemFundoSim.MouseFilter = Control.MouseFilterEnum.Ignore;


	}
	
	private void MostrarPensamentoNao() 
	{
		balaoPensamentoNao.Show();
	
		imagemFundoNao.Show();
		imagemFundoSim.Hide();
		
	}
	
	private void MostrarPensamentoSim() 
	{
		balaoPensamentoNao.Hide();
		
		imagemFundoSim.Show();
		imagemFundoNao.Hide();
	}
	
	private void OcultarPensamentos() 
	{
		balaoPensamentoNao.Hide();
		
		imagemFundoNao.Hide();
		imagemFundoSim.Hide();
	}


	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}

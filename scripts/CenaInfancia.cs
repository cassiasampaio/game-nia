using Godot;
using System;

public partial class CenaInfancia : Node2D
{
	private RichTextLabel textoDialogo;
	private Label nomeLocutor;
	private Button botaoSim;
	private Button botaoNao;
//	private PanelContainer balaoPensamentoSim;
//	private RichTextLabel textoPensamentoSim;
	private PanelContainer balaoPensamentoNao;
	private RichTextLabel textoPensamentoNao;
	
	private TextureRect imagemFundoNao;
	private TextureRect imagemFundoSim;
	
	
	// private ColorRect fundoEsquerdo;
	// private ColorRect fundoDireito;
	
	// private readonly Color corEsquerdaNormal = Color.FromHtml("#648CBE33");
	// private readonly Color corEsquerdaHover = Color.FromHtml("#648CBE99");
	// private readonly Color corDireitaNormal = Color.FromHtml("#D9906A33");
	// private readonly Color corDireitaHover = Color.FromHtml("#D9906A99");
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		textoDialogo = GetNode<RichTextLabel>("CanvasLayer2/DialogoUI/CaixaDialogo/TextoDialogo");
		nomeLocutor = GetNode<Label>("CanvasLayer2/DialogoUI/CaixaLocutor/NomeLocutor");
		botaoSim = GetNode<Button>("CanvasLayer2/DialogoUI/Opcoes/BotaoSim");
		botaoNao = GetNode<Button>("CanvasLayer2/DialogoUI/Opcoes/BotaoNao");
		balaoPensamentoNao = GetNode<PanelContainer>("CanvasLayer2/DialogoUI/BalaoPensamentoNao");
		textoPensamentoNao = GetNode<RichTextLabel>("CanvasLayer2/DialogoUI/BalaoPensamentoNao/TextoPensamentoNao");
	//	balaoPensamentoSim = GetNode<PanelContainer>("CanvasLayer2/DialogoUI/BalaoPensamentoSim");
	//	textoPensamentoSim = GetNode<RichTextLabel>("CanvasLayer2/DialogoUI/BalaoPensamentoSim/TextoPensamentoSim");
		imagemFundoNao = GetNode<TextureRect>("CanvasLayer/ImagemFundoNao");
		imagemFundoSim = GetNode<TextureRect>("CanvasLayer/ImagemFundoSim");
		// fundoEsquerdo = GetNode<ColorRect>("CanvasLayer/FundoEsquerdo");
		// fundoDireito = GetNode<ColorRect>("CanvasLayer/FundoDireito");
	
		textoDialogo.Text = "Ô minha filha, você tem que pentear esse cabelo! Uma menina tão bonita com o cabelo espantado assim...";
		nomeLocutor.Text = "Vovó Raimunda";
		
		textoPensamentoNao.Text = "Dizer que não gostou do que ela falou"; 
	//	textoPensamentoSim.Text = "Concordar e pedir para ela arrumar seu cabelo";
		
	//	balaoPensamentoSim.Hide();
		balaoPensamentoNao.Hide();
		
		botaoNao.MouseEntered += MostrarPensamentoNao;
		botaoSim.MouseEntered += MostrarPensamentoSim;
		
		botaoNao.MouseExited += OcultarPensamentos;
	//	botaoSim.MouseExited += OcultarPensamentos;
		
		imagemFundoNao.Hide();
		imagemFundoSim.Hide();
		
		imagemFundoNao.MouseFilter = Control.MouseFilterEnum.Ignore;
		imagemFundoSim.MouseFilter = Control.MouseFilterEnum.Ignore;

		// fundoEsquerdo.MouseEntered += MudarFundoEsquerdo;
		// fundoDireito.MouseEntered += MudarFundoDireito;
		
		// fundoEsquerdo.MouseExited += RestaurarFundoEsquerdo;
		// fundoDireito.MouseExited += RestaurarFundoDireito;

	}
	
	private void MostrarPensamentoNao() 
	{
		// balaoPensamentoSim.Hide();
		balaoPensamentoNao.Show();
	
		imagemFundoNao.Show();
		imagemFundoSim.Hide();
		
		/// fundoDireito.Color = corDireitaHover;
	}
	
	private void MostrarPensamentoSim() 
	{
		balaoPensamentoNao.Hide();
		// balaoPensamentoSim.Show();
		
		imagemFundoSim.Show();
		imagemFundoNao.Hide();
		// fundoEsquerdo.Color = corEsquerdaHover;
	}
	
	private void OcultarPensamentos() 
	{
	//	balaoPensamentoSim.Hide();
		balaoPensamentoNao.Hide();
		
		imagemFundoNao.Hide();
		imagemFundoSim.Hide();
	}

	// private void MudarFundoEsquerdo() 
	// {
	// 	fundoEsquerdo.Color = corEsquerdaHover;
	// }

	// private void MudarFundoDireito() 
	// {
	// fundoDireito.Color = corDireitaHover;
	// GD.Print("Teste hover fundo direito");
	// }

	// private void RestaurarFundoEsquerdo() 
	// {
	// 	fundoEsquerdo.Color = corEsquerdaNormal;
	// }

	// private void RestaurarFundoDireito() 
	// {
	// fundoDireito.Color = corDireitaNormal;
	// }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}

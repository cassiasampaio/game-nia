using Godot;
using System;

public partial class TelaInicial : Control
{
	private Button botaoIniciar;
	private Button botaoCreditos;
	
	private const string CaminhoCenaCreditos = "res://cenas/TelaCreditos.tscn";
	private const string CaminhoCenaInfancia = "res://cenas/CenaInfancia.tscn";
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		botaoIniciar = GetNode<Button>("MenuBotoes/BotaoIniciar");
		botaoCreditos = GetNode<Button>("MenuBotoes/BotaoCreditos");
		
		botaoIniciar.Pressed += IniciarJogo;
		botaoCreditos.Pressed += ExibirCreditos;
	}
	
	private void IniciarJogo()
	{
		GetTree().ChangeSceneToFile(CaminhoCenaInfancia);
	}

	private void ExibirCreditos()
	{
		GetTree().ChangeSceneToFile(CaminhoCenaCreditos);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}

using Godot;
using System;

public partial class TelaCreditos : Control
{
	private TextureButton botaoReiniciar;
	
	private const string CaminhoReiniciar = "res://cenas/TelaInicial.tscn";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		botaoReiniciar = GetNode<TextureButton>("BotaoReiniciar");
		botaoReiniciar.Pressed += ReiniciarJogo;

	}
	
	private void ReiniciarJogo()
	{
		GetTree().ChangeSceneToFile(CaminhoReiniciar);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}

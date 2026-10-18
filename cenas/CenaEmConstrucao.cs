using Godot;
using System;

public partial class CenaEmConstrucao : Control
{
	private TextureButton botaoCreditos;
	
	private const string CaminhoTelaCreditos = "res://cenas/Telacreditos.tscn";
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		botaoCreditos = GetNode<TextureButton>("BotaoCreditos");
		botaoCreditos.Pressed += MudarTelaCreditos;
	}

	private void MudarTelaCreditos()
	{
		GetTree().ChangeSceneToFile(CaminhoTelaCreditos);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	
	}
}

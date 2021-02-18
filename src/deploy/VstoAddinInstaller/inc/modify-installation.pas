
Const 
  mrRepair = 100;
  mrUninstall = 101;
  OptionsFormCaption = 'Setup options...';
  RepairButtonCaption = 'Repair';
  UninstallButtonCaption = 'Uninstall';

Function ShowOptionsForm: TModalResult;

Var 
  OptionsForm: TSetupForm;
  RepairButton: TNewButton;
  UninstallButton: TNewButton;
Begin
  Result := mrNone;
  OptionsForm := CreateCustomForm;
  Try
    OptionsForm.Width := 220;
    OptionsForm.Caption := ExpandConstant('{cm:OptionsFormCaption}');
    OptionsForm.Position := poScreenCenter;
    RepairButton := TNewButton.Create(OptionsForm);
    RepairButton.Parent := OptionsForm;
    RepairButton.Left := 8;
    RepairButton.Top := 8;
    RepairButton.Width := OptionsForm.ClientWidth - 16;
    RepairButton.Caption := ExpandConstant('{cm:RepairButtonCaption}');
    RepairButton.ModalResult := mrRepair;
    UninstallButton := TNewButton.Create(OptionsForm);
    UninstallButton.Parent := OptionsForm;
    UninstallButton.Left := 8;
    UninstallButton.Top := RepairButton.Top + RepairButton.Height + 8;
    UninstallButton.Width := OptionsForm.ClientWidth - 16;
    UninstallButton.Caption := ExpandConstant('{cm:UninstallButtonCaption}');
    UninstallButton.ModalResult := mrUninstall;
    OptionsForm.ClientHeight := RepairButton.Height + UninstallButton.Height + 24;
    Result := OptionsForm.ShowModal;
  Finally
    OptionsForm.Free;
End;
End;

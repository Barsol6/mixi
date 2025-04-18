﻿namespace mixi.Modules.UI;

public class PdfPopup
{
    private string _pdfName = String.Empty;
    
    public event Action? PdfNameChanged;
    
    public string PdfName
    {
        get => _pdfName;
        set
        {
            if (_pdfName != value)
            {
                _pdfName = value;
                PdfNameChanged?.Invoke();
            }
        }
    }
    
    private bool _isVisible;
    
    public event Action? IsVisibleChange;
    
    public bool IsVisible
    {
        get => _isVisible;
        set
        {
            if (_isVisible != value)
            {
                _isVisible = value;
                IsVisibleChange?.Invoke();
            }
        }
    }
}
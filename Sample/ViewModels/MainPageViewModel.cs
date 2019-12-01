using System;
using Prism.Mvvm;
using Reactive.Bindings;

namespace Sample.ViewModels
{
    public class MainPageViewModel:BindableBase
    {
        public ReactivePropertySlim<bool> IsActive { get; } = new ReactivePropertySlim<bool>();
        public ReactiveCommand OnCommand { get; } = new ReactiveCommand();
        public ReactiveCommand OffCommand { get; } = new ReactiveCommand();


        public MainPageViewModel()
        {
            OnCommand.Subscribe(_ =>
            {
                IsActive.Value = true;
            });

            OffCommand.Subscribe(_ =>
            {
                IsActive.Value = false;
            });
        }
    }
}

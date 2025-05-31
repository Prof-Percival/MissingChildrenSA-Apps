using CommunityToolkit.Mvvm.Input;
using MissingChildrenSA.Models;

namespace MissingChildrenSA.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}
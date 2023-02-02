using GameCreator.Runtime.VisualScripting;

namespace Slate.ActionClips.GameCreator2
{
    [Category("Game Creator 2")]
    public class InvokeGameCreator2Instruction : ActorActionClip
    {
        public Actions GameCreatorAction;
        public string Comment = "Invoke Instruction";

        //This is written within the clip in the editor
        public override string info{
            get {return Comment;}
        }

        //Called in forward sampling when the clip is entered
        protected override void OnEnter()
        {
            GameCreatorAction.Invoke();
        }
    }
}
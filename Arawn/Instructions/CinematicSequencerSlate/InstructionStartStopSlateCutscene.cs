using System;
using System.Threading.Tasks;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.VisualScripting;
using UnityEngine;
using Slate;

namespace GameCreator.Runtime.VisualScripting.Arawn
{
    [Version(1, 0, 0)]
    [Title("Start or Stop a Cutscene in SLATE")]
    [Common.Description("Drag and drop the cutscene into this action to play the cutscene. If you want to stop the cutscene, then check Stop Cutscene.")]
    [Image(typeof(IconEye), ColorTheme.Type.Gray)]
    [Common.Category("ParadoxNotion/SLATE/Start or Stop Cutscene")]
    
    [Parameter("SLATE Cutscene", "The Slate Cutscene GameObject")]
    [Parameter("Stop Cutscene", "Color target that the instantiated Material turns into")]
    
    [Keywords("ParadoxNotion", "Cinematic Sequencer", "Timeline", "Slate", "Cutscene", "3rd Party", "Asset")]

    [Serializable]
    public class InstructionStartStopSlateCutscene : Instruction
    {
        [SerializeField] private PropertyGetGameObject m_Cutscene = new PropertyGetGameObject();
        [SerializeField] private PropertyGetBool m_StopCutscene = new PropertyGetBool(false);
        protected override Task Run(Args args)
        {
            GameObject gameObject = this.m_Cutscene.Get(args);
            Cutscene cutscene = gameObject.GetComponent<Cutscene>();
            bool stopCutscene = this.m_StopCutscene.Get(args);

            if (stopCutscene == false)
            {
                cutscene.Play();
            }
            else
            {
                cutscene.Stop();
            }
            return DefaultResult;
        }
    }
}

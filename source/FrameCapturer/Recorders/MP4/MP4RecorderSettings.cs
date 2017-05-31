using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Recorder.FrameRecorder;
using UnityEngine.Recorder.FrameRecorder.DataSource;

namespace UTJ.FrameCapturer.Recorders
{
    [ExecuteInEditMode]
    public class MP4RecorderSettings : BaseFCRecorderSettings
    {
        public fcAPI.fcMP4Config m_MP4EncoderSettings = fcAPI.fcMP4Config.default_value;

        public override List<RecorderInputSetting> GetDefaultSourcesSettings()
        {
            return new List<RecorderInputSetting>() { ScriptableObject.CreateInstance<CBRenderTextureInputSettings>() };
        }
    }
}
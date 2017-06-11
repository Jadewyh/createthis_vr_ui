﻿namespace CreateThis.VR.UI {
    public static class Defaults {
        public static PanelProfile panel;
        public static ButtonProfile momentaryButton;
        public static ButtonProfile toggleButton;
        public static PanelContainerProfile panelContainer;

        private static T OverrideDefault<T>(T defaultProfile, T overrideProfile) {
            T result = defaultProfile;
            if (overrideProfile != null) result = overrideProfile;
            return result;
        }

        public static PanelProfile GetProfile(PanelProfile overrideProfile) {
            return OverrideDefault(panel, overrideProfile);
        }

        public static ButtonProfile GetMomentaryButtonProfile(ButtonProfile overrideProfile) {
            return OverrideDefault(momentaryButton, overrideProfile);
        }

        public static ButtonProfile GetToggleButtonProfile(ButtonProfile overrideProfile) {
            return OverrideDefault(toggleButton, overrideProfile);
        }

        public static PanelContainerProfile GetProfile(PanelContainerProfile overrideProfile) {
            return OverrideDefault(panelContainer, overrideProfile);
        }
    }
}
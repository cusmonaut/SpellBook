using System;

namespace MysticReference.Domain
{
    [Serializable]
    public class Spell
    {
        public string name { get; set; }

        public string school { get; set; }

        public string subschool { get; set; }

        public string descriptor { get; set; }

        public string spell_level { get; set; }

        public string casting_time { get; set; }

        public string components { get; set; }

        public string costly_components { get; set; }

        public string range { get; set; }

        public string area { get; set; }

        public string effect { get; set; }

        public string targets { get; set; }

        public string duration { get; set; }

        public string dismissible { get; set; }

        public string shapeable { get; set; }

        public string saving_throw { get; set; }

        public string spell_resistence { get; set; }

        public string description { get; set; }

        public string description_formated { get; set; }

        public string source { get; set; }

        public string full_text { get; set; }

        public string verbal { get; set; }

        public string somatic { get; set; }

        public string material { get; set; }

        public string focus { get; set; }

        public string divine_focus { get; set; }

        public string sor { get; set; }

        public string wiz { get; set; }

        public string cleric { get; set; }

        public string druid { get; set; }

        public string ranger { get; set; }

        public string bard { get; set; }

        public string paladin { get; set; }

        public string alchemist { get; set; }

        public string summoner { get; set; }

        public string witch { get; set; }

        public string inquisitor { get; set; }

        public string oracle { get; set; }

        public string antipaladin { get; set; }

        public string magus { get; set; }

        public string adept { get; set; }

        public string deity { get; set; }

        public string SLA_Level { get; set; }

        public string domain { get; set; }

        public string short_description { get; set; }

        public string acid { get; set; }

        public string air { get; set; }

        public string chaotic { get; set; }

        public string cold { get; set; }

        public string curse { get; set; }

        public string darkness { get; set; }

        public string death { get; set; }

        public string disease { get; set; }

        public string earth { get; set; }

        public string electricity { get; set; }

        public string emotion { get; set; }

        public string evil { get; set; }

        public string fear { get; set; }

        public string fire { get; set; }

        public string force { get; set; }

        public string good { get; set; }

        public string language_dependent { get; set; }

        public string lawful { get; set; }

        public string light { get; set; }

        public string mind_affecting { get; set; }

        public string pain { get; set; }

        public string poison { get; set; }

        public string shadow { get; set; }

        public string sonic { get; set; }

        public string water { get; set; }

        public string linktext { get; set; }

        public string id { get; set; }

        public string material_costs { get; set; }

        public string bloodline { get; set; }

        public string patron { get; set; }

        public string mythic_text { get; set; }

        public string augmented { get; set; }

        public string mythic { get; set; }

        public string bloodrager { get; set; }

        public string shaman { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}{15}School: {1}{15}SubSchool: {2}{15}Descriptor: {3}{15}Level: {4}{15}Components: " +
                          "{5}{15}Casting Time: {6}{15}Range: {7}{15}Area: {8}{15}Effect: {9}{15}Target: {10}{15}Duration: " +
                          "{11}{15}Saving Throw: {12}{15}Spell Resistance: {13}{15}Description:{15}{14}",
                         name, school, subschool, descriptor,
                         spell_level, components, casting_time, range,
                         area, effect, targets, duration, saving_throw,
                         spell_resistence, description, Environment.NewLine);
        }
    }
}
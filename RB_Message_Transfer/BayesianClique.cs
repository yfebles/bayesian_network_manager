using System.Collections.Generic;
using System.Linq;

namespace RB_Message_Transfer
{
    public class BayesianClique
    {
        public List<BayesianNode> Nodes { get; set; }
        public List<BayesianNode> Representativos { get; set; }
        public Dictionary<BayesianClique,Dictionary<string,double>> NeighborMsg { get; private set; }
        public string Name { get; set; }
        int _cantneighbors;
        
        public void Inicialize(int cantNeighbors)
        {
            ConditionalProbability = new Dictionary<string,double>();
            NeighborMsg = new Dictionary<BayesianClique, Dictionary<string, double>>(cantNeighbors);
            _cantneighbors = cantNeighbors;
        }
               

        public bool CanSendMesg(BayesianClique neighbor)
        {
            return (NeighborMsg.Count==_cantneighbors || (NeighborMsg.Count==_cantneighbors-1 && !ContainsKeyDict(neighbor)));
        }

        private bool ContainsKeyDict(BayesianClique clique)
        {
            foreach (var key in NeighborMsg.Keys)
                if (key.Name == clique.Name)
                    return true;
            return false;

        }

        public bool MsgSended(BayesianClique neighbor)
        {
            return neighbor.NeighborMsg.ContainsKey(this);
        }
                

        public bool ProbabilityDone
        {
            get { return ConditionalProbability.Count > 0; }
        }


        public bool CanComputeProbability
        {
            get { return NeighborMsg.Count==_cantneighbors; }
        }

        public Dictionary<string,double> ConditionalProbability { get; private set; }

        
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor; // 빌드가 안된다. using 네임스페이스중에는 빌드가 안되는 친구들이 있다.

public class ResourceManager : MonoBehaviour
{
    private static ResourceManager m_instance;
    public static ResourceManager instance
    {
        get
        {
            // 만약 싱글톤 변수에 아직 오브젝트가 할당되지 않았다면
            if (m_instance == null)
            {
                // 씬에서 GameManager 오브젝트를 찾아 할당
                m_instance = FindObjectOfType<ResourceManager>();
            }

            // 싱글톤 오브젝트를 반환
            return m_instance;
        }
    }

    //private string dataPath
    private static string zombieDataPath = default;
    public ZombieData zombieData_Default = default;


    private void Awake()
    {
        //dataPath = Application.dataPath;
        //zombieDataPath = string.Format("{0}/{1}", dataPath, "01 Zomebie/Scriptables");

        //byte[] byteZombieData = File.ReadAllBytes(zombieDataPath + "/Zombie Data Default");

        //ZombieData zombieData_ = AssetDatabase.LoadAssetAtPath<ZombieData>(zombieDataPath);
       
        zombieDataPath = "Scriptables";
        zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "Zombie Data Default");

        zombieData_Default = Resources.Load<ZombieData>(zombieDataPath);

        Debug.LogFormat("게임 Save date 를 여기에다가 저장하는 것이 상식이다. => {0}", Application.persistentDataPath);

        //zombieData_Default = AssetDatabase.LoadAssetAtPath<ZombieData>(zombieDataPath);
        //ZombieData zombieData_ = Resources.Load<ZombieData>(zombieDataPath);


        //Debug.LogFormat("Zombie Data Path : {0}", zombieDataPath);
        //Debug.LogFormat("Zombie data : {0}, {1}, {2}",
        //    zombieData_.health, zombieData_.damage, zombieData_.speed);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

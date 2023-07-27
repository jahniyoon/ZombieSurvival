using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor; // ���尡 �ȵȴ�. using ���ӽ����̽��߿��� ���尡 �ȵǴ� ģ������ �ִ�.

public class ResourceManager : MonoBehaviour
{
    private static ResourceManager m_instance;
    public static ResourceManager instance
    {
        get
        {
            // ���� �̱��� ������ ���� ������Ʈ�� �Ҵ���� �ʾҴٸ�
            if (m_instance == null)
            {
                // ������ GameManager ������Ʈ�� ã�� �Ҵ�
                m_instance = FindObjectOfType<ResourceManager>();
            }

            // �̱��� ������Ʈ�� ��ȯ
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

        Debug.LogFormat("���� Save date �� ���⿡�ٰ� �����ϴ� ���� ����̴�. => {0}", Application.persistentDataPath);

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

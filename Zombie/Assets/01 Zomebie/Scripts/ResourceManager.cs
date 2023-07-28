using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;

public class ResourceManager : MonoBehaviour
{
    private static ResourceManager m_instance; // �̱����� �Ҵ�� static ����
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

    private static string zombieDataPath = default;

    public ZombieData zombieData_default = default;

    public List<ZombieData2> zombieDatas = default;

    private void Awake()
    {
        //ZombieDatas �ʱ�ȭ
        zombieDatas = new List<ZombieData2>();

        zombieDataPath = "ZombieDatas";
        zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "ZombieSurvival Datas - ZombieDatas"); //�� ���ʿ� �������� �������� �̸� ��������

        TextAsset csvZombieData = Resources.Load<TextAsset>(zombieDataPath);

        string[] zombieDatas_str = csvZombieData.text.Split('\n');
        ZombieData2 loadZombieData = default;
        for (int i = 1; i < zombieDatas_str.Length; i++)
        {
            loadZombieData = new ZombieData2(zombieDatas_str[i]);
            zombieDatas.Add(loadZombieData);

        }
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